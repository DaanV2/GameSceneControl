using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;


[QueryProperty("RoomInfo", "info")]
public partial class RoomEditPage : ContentPage {
    public RoomEditPage(RoomEditPageModel Model) {
        this.InitializeComponent();
        this.BindingContext = Model;
    }


    protected override void OnDisappearing() {
        if (this.BindingContext is not RoomEditPageModel RPM) return;

        _ = RPM.RoomInfo.Store();
    }
}