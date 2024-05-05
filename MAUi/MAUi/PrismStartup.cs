using MAUi.Views;

namespace MAUi;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart(nameof(HomePage));
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                         .RegisterForNavigation<HomePage>()
                         .RegisterInstance(SemanticScreenReader.Default);
    }
}

