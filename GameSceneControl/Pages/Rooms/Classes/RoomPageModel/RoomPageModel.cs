using GameSceneControl.Rooms;
using GameSceneControl.Rooms.Controllers;

namespace GameSceneControl.Pages.Rooms {
    [QueryProperty(nameof(RoomInfo), "info")]
    public partial class RoomPageModel : BaseViewModel {
        private RoomInfo _RoomInfo;
        private IRoomController _Controller;

        public RoomInfo RoomInfo {
            get => this._RoomInfo;
            set {
                this._RoomInfo = value;
                this.OnPropertyChanged();
            }
        }

        public IRoomController Controller {
            get => this._Controller;
            set {
                this._Controller = value;
                this.OnPropertyChanged();
            }
        }
    }
}
