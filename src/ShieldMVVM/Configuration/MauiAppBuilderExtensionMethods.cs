using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.Pages;
using CoreBTS.Maui.ShieldMVVM.ViewModel;
using System.Collections.Concurrent;
using System.Reflection;

namespace CoreBTS.Maui.ShieldMVVM.Configuration;

/// <summary>
/// This class registers all the different types used by ShieldMVVM in the IoC container.
/// </summary>
public static class MauiAppBuilderExtensionMethods
{
    private static readonly Type _pageType = typeof(ContentPageBase<>);
    private static readonly Type _dialogPageType = typeof(DialogPageBase<>);
    private static readonly Type _vmType = typeof(IViewModelBase);

    /// <summary>
    /// Configures the built in INavigationService to navigate between pages via a ViewModel and
    /// registers all ViewModels, ContentPageBase, and DialogPageBase types.
    /// </summary>
    /// <param name="builder">A builder for .NET MAUI cross-platform applications and services.</param>
    /// <param name="typeResolverCallback">The callback to an IoC container to return the resolved type.</param>
    /// <param name="assembliesToScan">
    /// The list of assemblies to scan for IViewModelBase, ContentPageBase, and DialogPageBase types.
    /// </param>
    /// <returns>The same builder that was sent in for chaining.</returns>
    public static MauiAppBuilder UseShieldMVVM(
        this MauiAppBuilder builder, 
        Func<Type, dynamic?> typeResolverCallback, 
        params Assembly[] assembliesToScan)
    {
        builder.Services.AddSingleton<INavigationService>(new NavigationService(typeResolverCallback));

        var assemblies = assembliesToScan.ToList();
        var currentAssembly = typeof(MauiAppBuilderExtensionMethods).Assembly;

        if (assemblies.Any(a => a != currentAssembly)) 
        {
            assemblies.Add(currentAssembly);
            assembliesToScan = [.. assemblies];
        }

        ConfigureViewModels(builder, assembliesToScan);
        ConfigurePages(builder, assembliesToScan);
        ConfigureDialogs(builder, assembliesToScan);

        return builder;
    }

    /// <summary>
    /// Does NOT configure the built in INavigationService to navigate between pages. Only registers 
    /// ViewModels, ContentPageBase, and DialogPageBase types.
    /// </summary>
    /// <param name="builder">A builder for .NET MAUI cross-platform applications and services.</param>
    /// <param name="assembliesToScan">
    /// The list of assemblies to scan for IViewModelBase, ContentPageBase, and DialogPageBase types.
    /// </param>
    /// <returns>The same builder that was sent in for chaining.</returns>
    public static MauiAppBuilder UseShieldMVVMNoNavigation(
        this MauiAppBuilder builder,
        params Assembly[] assembliesToScan)
    {
        ConfigureViewModels(builder, assembliesToScan);
        ConfigurePages(builder, assembliesToScan);
        ConfigureDialogs(builder, assembliesToScan);

        return builder;
    }

    /// <summary>
    /// Scans all the given assemblies for any classes that implement IViewModelBase interface and registers them with
    /// the Services IoC container.
    /// </summary>
    /// <param name="builder">A builder for .NET MAUI cross-platform applications and services.</param>
    /// <param name="assembliesToScan">The list of assemblies to scan for IViewModelBase types.</param>
    /// <returns>The same builder that was sent in for chaining.</returns>
    private static MauiAppBuilder ConfigureViewModels(MauiAppBuilder builder, params Assembly[] assembliesToScan)
    {
        if (assembliesToScan == null)
            return builder;

        foreach (var assembly in assembliesToScan)
        {
            RegisterViewModelsInAssembly(builder, assembly);
        }

        return builder;
    }

    /// <summary>
    /// Scans all the given assemblies for any classes that inherits from the ContentPageBase&lt;&gt; class 
    /// and registers them with the Services IoC container.
    /// </summary>
    /// <param name="builder">A builder for .NET MAUI cross-platform applications and services.</param>
    /// <param name="assembliesToScan">The list of assemblies to scan for ContentPageBase&lt;&gt; types.</param>
    /// <returns>The same builder that was sent in for chaining.</returns>
    private static MauiAppBuilder ConfigurePages(MauiAppBuilder builder, params Assembly[] assembliesToScan)
    {
        if (assembliesToScan == null)
            return builder;

        foreach (var assembly in assembliesToScan)
        {
            RegisterPagesInAssembly(builder, assembly);
        }

        return builder;
    }

    /// <summary>
    /// Scans all the given assemblies for any classes that inherits from the ContentPageBase&lt;&gt; class 
    /// and registers them with the Services IoC container.
    /// </summary>
    /// <param name="builder">A builder for .NET MAUI cross-platform applications and services.</param>
    /// <param name="assembliesToScan">The list of assemblies to scan for ContentPageBase&lt;&gt; types.</param>
    /// <returns>The same builder that was sent in for chaining.</returns>
    private static MauiAppBuilder ConfigureDialogs(MauiAppBuilder builder, params Assembly[] assembliesToScan)
    {
        if (assembliesToScan == null)
            return builder;

        foreach (var assembly in assembliesToScan)
        {
            RegisterDialogsInAssembly(builder, assembly);
        }

        return builder;
    }

    private static void RegisterViewModelsInAssembly(MauiAppBuilder builder, Assembly assembly)
    {
        foreach (var type in assembly.GetTypes())
        {
            if (type.IsAbstract || type.IsInterface || !type.IsAssignableTo(_vmType))
                continue;

            builder.Services.AddTransient(type);
        }
    }

    private static void RegisterPagesInAssembly(MauiAppBuilder builder, Assembly assembly)
    {
        var types = assembly.GetTypes();
        foreach (var pageType in types)
        {
            if (pageType.IsAbstract || pageType.IsInterface || !IsAssignableToGenericType(pageType, _pageType))
                continue;

            var vmType = GetPageGenericType(pageType);

            NavigationService.ViewModelPageLookup.TryAdd(vmType, pageType);
            builder.Services.AddTransient(_pageType.MakeGenericType(vmType), pageType);

            RegisterParentTypes(builder, NavigationService.ViewModelPageLookup, _pageType, types, pageType, vmType);
        }
    }

    private static void RegisterDialogsInAssembly(MauiAppBuilder builder, Assembly assembly)
    {
        var types = assembly.GetTypes();
        foreach (var pageType in types)
        {
            if (pageType.IsAbstract || pageType.IsInterface || !IsAssignableToGenericType(pageType, _dialogPageType))
                continue;

            var vmType = GetPageGenericType(pageType);

            NavigationService.ViewModelDialogPageLookup.TryAdd(vmType, pageType);
            builder.Services.AddTransient(_dialogPageType.MakeGenericType(vmType), pageType);

            RegisterParentTypes(builder, NavigationService.ViewModelDialogPageLookup, _dialogPageType, types, pageType, vmType);
        }
    }

    private static void RegisterParentTypes(
        MauiAppBuilder builder, 
        ConcurrentDictionary<Type, Type> lookup, 
        Type genericType, 
        Type[] types, 
        Type pageType, 
        Type baseViewModelType)
    {
       foreach (var vmType in types)
        {
            if (vmType.IsAbstract || vmType.IsInterface || vmType.BaseType != baseViewModelType)
                continue;

            lookup.TryAdd(vmType, pageType);
            builder.Services.AddTransient(genericType.MakeGenericType(vmType), pageType);

            RegisterParentTypes(builder, lookup, genericType, types, pageType, vmType);
        }
    }

    private static Type GetPageGenericType(Type page)
    {
        if (page.IsGenericType)
            return page.GetGenericArguments().First();

        if (page.BaseType == null)
            throw new InvalidOperationException($"The given page '{page.FullName}' does not inherit from required ContentPageBase<>");

        return GetPageGenericType(page.BaseType);
    }

    private static bool IsAssignableToGenericType(Type givenType, Type genericType)
    {
        if (givenType.IsGenericType && givenType.GetGenericTypeDefinition() == genericType)
            return true;

        Type? baseType = givenType.BaseType;
        if (baseType == null) 
            return false;

        return IsAssignableToGenericType(baseType, genericType);
    }
}