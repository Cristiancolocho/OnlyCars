using Microsoft.Extensions.Logging;

namespace OnlyCars
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Proelium.otf", "ProeLi");
                    fonts.AddFont("Starz 2.ttf", "Starz");
                    fonts.AddFont("Cars.ttf", "Cars");
                    fonts.AddFont("MOTOB___.TTF", "MOTO");
                    fonts.AddFont("motorama.ttf", "Motorama");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
