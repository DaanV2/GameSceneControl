
using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;
public partial class RoomsPage : ContentPage {


    public RoomsPage(RoomsInfoModel Model) {
        this.InitializeComponent();

        this.BindingContext = Model;
    }

    private void Button_Add_Clicked(Object sender, EventArgs e) {
        GameSceneControl.Navigation.GotoPage(nameof(NewRoomPage));
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        (this.BindingContext as RoomsInfoModel).GetRooms();
    }

    private void Room_Tapped(Object sender, EventArgs e) {
        if (sender is not BindableObject binded) return;
        if (binded.BindingContext is not RoomInfo context) return;

        RoomPage.OpenRoomPage(context);
    }

    private void ButtonEdit_Invoked(Object sender, EventArgs e) {
        if (sender is not BindableObject binded) return;
        if (binded.BindingContext is not RoomInfo Info) return;

        GameSceneControl.Navigation.GotoPage(nameof(RoomEditPage), ("info", Info));
    }

    private void DeleteButton_Invoked(Object sender, EventArgs e) {
        if (sender is not BindableObject binded) return;
        if (binded.BindingContext is not RoomInfo Info) return;

        this.DeleteRoom(Info);
    }
    private async void DeleteRoom(RoomInfo Info) {
        Boolean answer = await this.DisplayAlert("Are you sure?", $"You are about to delete the room: {Info.Name}", "Yes", "No");

        if (answer == true) {
            if (Controller.Remove(Info) && this.BindingContext is RoomsInfoModel Model) {
                _ = Model.Rooms.Remove(Info);
            }
        }
    }
}