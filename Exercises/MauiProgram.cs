using CommunityToolkit.Maui;
using Exercises.Pages;
using Microsoft.Extensions.Logging;

namespace Exercises; 
public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransient<ExamplePage>().AddTransient<MessageListPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}