using Microsoft.Extensions.Logging;
using Toverland.Data;

namespace Toverland;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        
        builder.Services.AddHttpClient<ApiService>(client =>
        {
            client.BaseAddress = new Uri("http://localhost:5114/api/");
        });


        return builder.Build();
    }
}