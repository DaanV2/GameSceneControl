
using GameSceneControl.Pages.Rooms;

namespace GameSceneControl;

public partial class AppShell : Shell {
    public AppShell() {
        this.InitializeComponent();

        //Routes
        Routing.RegisterRoute(nameof(RoomsPage), typeof(RoomsPage));
        Routing.RegisterRoute(nameof(RoomEditPage), typeof(RoomEditPage));
        Routing.RegisterRoute(nameof(NewRoomPage), typeof(NewRoomPage));
    }
}
