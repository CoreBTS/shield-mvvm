# Shield MVVM

## ViewModels

### Lifecycle

#### Creation

With Shield MVVM, the View Model will be created by itself outside of the page to allow for other advanced scenarios. Before running any methods, the IsBusy method will be set to true in order for you to show a loading indicator of some sort.

#### Prepare

If the View Model takes a TParameter, then this will be called first with that navigation data. This will setup any initial data the View Model needs before a full initializing takes place. You should not load any data in this method.

#### InitializeAsync

If the IsInitializeCalledBeforePageIsCreated property is set to true (true by default), then InitializeAsync will run. Right before running, IsBusy is set to true. This will run before it is bound to the page, so the previous page would still be visible to the user while this is running. Most of the heavy loading data should be loaded in this method. When finished, IsBusy will be set to false.

#### OnViewCreated

This method will run after the Page is created and this ViewModel is bound to that page. It will only ever run once.

#### Page Navigated To

At this point, the page is pushed onto the navigation stack and should be visible on the screen.

#### InitializeAsync

If the IsInitializeCalledBeforePageIsCreated property is set to false (true by default), then InitializeAsync will run at this point. Right before running, IsBusy is set to true. This will run after it is bound to the page and the page is visible. Most of the heavy loading data should be loaded in this method. When finished, IsBusy will be set to false.

#### TResult

If this ViewModel returns a result, the navigation call will wait until the ViewModel is completed by calling the GoBackAsync method. This allows the original caller to directly receive the type-safe result from the navigation call.

### Advanced Scenarios

#### View Model Inheritance

Sometimes, a developer may define a View Model for a specific page that could be re-used, but there are a lot of differences in the data or how the View Model itself is built up. Instead of having to create a new XAML page that would be a copy and paste of the original page or a complex parameter arg class, a developer can create a new View Model that inherits the original. Then the various specific methods, properties, etc. can be overridden as needed and other View Models can navigate directly to this one. Shield MVVM will automatically know that this inherited View Model should be tied to the base class's XAML page and will do so automatically. However, the TParameter/TResult class generic types would need to match the base class's type UNLESS a different IViewModel<TParameter> or IViewModel<TParameter, TResult> is implemented on the new View Model. It is highly recommended that this new TParameter inherits from the base TParameter or wraps it so all the Prepare methods can be called correctly.