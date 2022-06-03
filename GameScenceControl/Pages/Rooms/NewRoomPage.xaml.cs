using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;

public partial class NewRoomPage : ContentPage {
    public NewRoomPage() {
        this.InitializeComponent();
    }


    public RoomInfo RoomInfo => new(this.Name.Text, this.ID.Text, this.Description.Text);


    private void Button_Add_Clicked(Object sender, EventArgs e) {

    }

    private void Button_Cancel_Clicked(Object sender, EventArgs e) {

    }
}