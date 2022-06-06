using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;

[QueryProperty("RoomInfo", "info")]
public partial class RoomPage : ContentPage {
    public RoomPage(RoomPageModel Model) {
        this.InitializeComponent();
        this.BindingContext = Model;
    }
}