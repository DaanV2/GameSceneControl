using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms {
    [QueryProperty(nameof(RoomInfo), "info")]
    public partial class RoomEditPageModel : BaseViewModel {
        private RoomInfo _RoomInfo;

        public RoomEditPageModel() {

        }

        public RoomInfo RoomInfo {
            get => this._RoomInfo;
            set {
                this._RoomInfo = value;
                this.OnPropertyChanged();
            }
        }
    }
}
