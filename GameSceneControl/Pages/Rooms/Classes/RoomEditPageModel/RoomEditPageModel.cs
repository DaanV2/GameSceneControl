using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms {
    [QueryProperty(nameof(RoomInfo), "info")]
    public partial class RoomEditPageModel : BaseViewModel {
        public RoomEditPageModel(RoomInfo roomInfo) {
            this.RoomInfo = roomInfo;
        }

        public RoomInfo RoomInfo { get; set; }
    }
}
