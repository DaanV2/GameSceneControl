using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;

[QueryProperty("RoomInfo", "info")]
public partial class RoomPage : TabbedPage {
    public RoomPage(RoomPageModel Model) {
        this.InitializeComponent();
        this.BindingContext = Model;
    }
}