namespace GameScenceControl;

public partial class MainPage : ContentPage {

    public MainPage() {
        InitializeComponent();
    }

    private void RoomButton_Clicked(object sender, EventArgs e) {
        Navigation.PushAsync(new Pages.RoomsPage());
    }
}