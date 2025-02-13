using CommunityToolkit.Maui;
using CoreBTS.Maui.ShieldMVVM.Configuration;
using MauiSample.Features.About;
using Microsoft.Extensions.Logging;

namespace MauiSample
{
    public static class MauiProgram
    {
        private static IServiceProvider? ServiceProvider;

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiCommunityToolkit()
                .UseMauiApp<App>()
                .UseShieldMVVM(t => ServiceProvider?.GetService(t),
                    [
                        typeof(AboutPageViewModel)
                    ],
                    typeof(MauiProgram).Assembly)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            var result = builder.Build();
            ServiceProvider = result.Services;
            return result;
        }
    }
}