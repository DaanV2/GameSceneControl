
using GameSceneControl.Pages.Rooms;

namespace GameSceneControl;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(RoomsPage), typeof(RoomsPage));
        Routing.RegisterRoute(nameof(RoomPage), typeof(RoomPage));
    }
}
