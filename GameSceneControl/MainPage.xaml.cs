using GameSceneControl.Pages;
using GameSceneControl.Pages.Rooms;

namespace GameSceneControl;

public partial class MainPage : ContentPage {

    public MainPage() {
        InitializeComponent();
    }

    private void RoomButton_Clicked(object sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(RoomsPage));
    }
}