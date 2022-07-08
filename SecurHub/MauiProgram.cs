using Blazored.Modal;
using Microsoft.AspNetCore.Components.WebView.Maui;
using SecurHub.Data;
using SecurHub.Services;
using SQLite;

namespace SecurHub;

public static class MauiProgram
{

    public static SQLiteConnection conn ;
    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        builder.Services.AddBlazoredModal();
        builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
       
        builder.Services.AddSingleton<AreaService>();
	
        return builder.Build();

	}

  
  


}
