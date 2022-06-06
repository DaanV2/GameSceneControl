using GameSceneControl.Pages.Rooms;

namespace GameSceneControl;

public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        _ = builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => {
                _ = fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                _ = fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });


        builder.Services.AddSingleton<RoomsInfoModel>();
        builder.Services.AddSingleton<RoomsPage>();
        builder.Services.AddSingleton<RoomsInfoModel>();

        builder.Services.AddTransient<NewRoomPage>();
        builder.Services.AddTransient<RoomPage>();
        builder.Services.AddTransient<RoomPageModel>();

        return builder.Build();
    }
}
