
using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;
public partial class RoomsPage : ContentPage {
    public RoomsPage(RoomsInfoModel Model) {
        this.InitializeComponent();

        this.BindingContext = Model;
    }

    private void Button_Add_Clicked(Object sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(NewRoomPage));
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        (this.BindingContext as RoomsInfoModel).GetRooms();
    }

    private void Room_Tapped(Object sender, EventArgs e) {
        if (sender is not BindableObject binded) return;
        if (binded.BindingContext is not RoomInfo context) return;

        Shell.Current.GoToAsync(nameof(RoomPage), true, new Dictionary<String, Object> { { "info", context } });
    }
}