using Blazored.Toast;
using Core.Interfaces;
using Core.Services;
using EanBarCode13.Data;
using EanBarCode13.Services;
using Infraestructure.Repositories;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace EanBarCode13
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            var path = Path.Combine(FileSystem.AppDataDirectory, "eancoredb2.db3");

            var Configuration = builder.Configuration;

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddBlazoredToast();

            builder.Services.AddTransient<ISheetItemRepository, SheetItemRepository>(
                options => ActivatorUtilities.CreateInstance<SheetItemRepository>(options, path));
            builder.Services.AddTransient<ISheetRepository, SheetRepository>(
               options => ActivatorUtilities.CreateInstance<SheetRepository>(options, path));
            builder.Services.AddTransient<IWorkBookRepository, WorkBookRepository>(
               options => ActivatorUtilities.CreateInstance<WorkBookRepository>(options, path));

            builder.Services.AddTransient<IDialogCustomService, DialogCustomService>();

            builder.Services.AddSingleton<WeatherForecastService>();

            builder.Services.AddTransient<ISheetItemService, SheetItemService>();
            builder.Services.AddTransient<IWorkBookService, WorkBookService>();
            builder.Services.AddTransient<ISheetService, SheetService>();
            builder.Services.AddTransient<IExcelService, ExcelService>();


            return builder.Build();
        }
    }
}