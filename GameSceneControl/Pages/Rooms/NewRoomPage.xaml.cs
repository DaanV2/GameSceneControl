using GameSceneControl.Rooms;
using GameSceneControl.Rooms.Serialization;

namespace GameSceneControl.Pages.Rooms;

public partial class NewRoomPage : ContentPage {
    public NewRoomPage(RoomPageModel Model) {
        this.InitializeComponent();

        this.ID.Text = Guid.NewGuid().ToString();
    }

    public RoomInfo RoomInfo => new(this.Name.Text, this.ID.Text, this.Description.Text);

    private void Button_Add_Clicked(Object sender, EventArgs e) {
        RoomInfo Info = this.RoomInfo;
        var Data = new RoomData(Info.ID);

        Navigation.RemovePage(this);
        if (Info.Store() & Data.Store()) {
            GameSceneControl.Navigation.GotoPage(nameof(RoomPage), ("info", Info));
        }
        else {
            GameSceneControl.Navigation.GotoPage(nameof(RoomsPage));
        }
    }
    private void Button_Cancel_Clicked(Object sender, EventArgs e) {
        Navigation.RemovePage(this);
        GameSceneControl.Navigation.GotoPage(nameof(RoomsPage));
    }

    private void Validate_Input(Object sender, TextChangedEventArgs e) {
        this.Button_Add.IsEnabled = this.Name.HasText() && this.ID.HasText();
    }
}