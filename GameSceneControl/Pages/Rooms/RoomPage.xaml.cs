using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms;

[QueryProperty(nameof(RoomInfo), "info")]
public partial class RoomPage : ContentPage {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Info"></param>
    /// <returns></returns>
    public static void OpenRoomPage(RoomInfo Info) {
        var Model = new RoomPageModel(Info);
        Model.CheckController();
        
        GameSceneControl.Navigation.GotoPage(new RoomPage(Model))
    }

    public RoomPage(RoomPageModel Model) {
        this.InitializeComponent();
        this.BindingContext = Model;
    }

    ~RoomPage() {
        (this.BindingContext as RoomPageModel)?.Controller.Stop();
    }

    private void Button_Scenes_Clicked(Object sender, EventArgs e) {
        if (this.BindingContext is not RoomPageModel RPM) return;

        _ = this.Navigation.PushAsync(new RoomScenePage(RPM));
    }

    private void Button_Edit_Clicked(Object sender, EventArgs e) {
        if (this.BindingContext is not RoomPageModel RPM) return;

        var Model = new RoomEditPageModel(RPM.RoomInfo);
        _ = this.Navigation.PushAsync(new RoomEditPage(Model));
    }
}