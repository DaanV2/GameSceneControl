namespace GameSceneControl.Pages.Rooms;

[QueryProperty("RoomInfo", "info")]
public partial class RoomScenePage : ContentPage
{
	public RoomScenePage(RoomPageModel Model) {
        this.InitializeComponent();
        this.BindingContext = Model;
    }
}