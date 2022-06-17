using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;

[QueryProperty("RoomInfo", "info")]
public partial class RoomPage : ContentPage {
    public RoomPage(RoomPageModel Model) {
        this.InitializeComponent();
        this.BindingContext = Model;
    }

    private void Button_Scenes_Clicked(Object sender, EventArgs e) {
        if (this.BindingContext is not RoomPageModel RPM) return;

        this.Navigation.PushAsync(new RoomScenePage(RPM));
    }

    private void Button_Edit_Clicked(Object sender, EventArgs e) {
        if (this.BindingContext is not RoomPageModel RPM) return;

        this.Navigation.PushAsync(new RoomEditPage(RPM));
    }
}