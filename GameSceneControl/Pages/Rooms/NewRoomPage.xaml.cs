using GameSceneControl.Rooms;
using GameSceneControl.Rooms.Serialization;

namespace GameSceneControl.Pages.Rooms;

public partial class NewRoomPage : ContentPage {
    public NewRoomPage() {
        this.InitializeComponent();

        this.ID.Text = Guid.NewGuid().ToString();
    }

    public RoomInfo RoomInfo => new(this.Name.Text, this.ID.Text, this.Description.Text);

    private void Button_Add_Clicked(Object sender, EventArgs e) {
        RoomInfo Info = this.RoomInfo;
        var Data = new RoomData(Info.ID);

        if (Info.Store() & Data.Store()) {
             GameSceneControl.Navigation.GotoPage(nameof(RoomPage), new Dictionary<String, Object> { { "info", Info } });
        }
        else {
            GameSceneControl.Navigation.GotoPage(nameof(RoomsPage));            
        }
    }
    private void Button_Cancel_Clicked(Object sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(RoomsPage));
    }

    private void Validate_Input(Object sender, EventArgs e) {
        this.Button_Add.IsEnabled = this.Name.HasText() && this.ID.HasText();
    }
}