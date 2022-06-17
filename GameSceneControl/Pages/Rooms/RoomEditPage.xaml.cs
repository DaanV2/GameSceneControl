using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;

public partial class RoomEditPage : ContentPage {
    public RoomEditPage() {
        this.InitializeComponent();
    }


    public void InfoUpdate() {
        if (this.BindingContext is not RoomPageModel RPM) return;

        _ = RPM.RoomInfo.Store();
        RPM.RoomInfo = RPM.RoomInfo;
    }

    private async void Button_Delete_Clicked(Object sender, EventArgs e) {
        if (this.BindingContext is not RoomPageModel RPM) return;

        Boolean answer = await this.DisplayAlert("Are you sure?", $"You are about to delete the room: {RPM.RoomInfo.Name}", "Yes", "No");

        if (answer == true) {
            _ = GameSceneControl.Rooms.Controller.Remove(RPM.RoomInfo);
            this.Navigation.RemovePage(this);
            GameSceneControl.Navigation.GotoPage(nameof(RoomsPage));
        }
    }

    private void Editor_Completed(Object sender, EventArgs e) {
        this.InfoUpdate();
    }
}