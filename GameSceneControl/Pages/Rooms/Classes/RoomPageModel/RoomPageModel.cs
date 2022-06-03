using GameSceneControl.Classes.BaseViewModel;
using GameSceneControl.Rooms;

namespace GameSceneControl.Pages.Rooms {
    [QueryProperty(nameof(RoomInfo), "RoomInfo")]
    public partial class RoomPageModel : BaseViewModel {
        private RoomInfo roomInfo;

        public RoomInfo RoomInfo {
            get => this.roomInfo;
            set {
                this.roomInfo = value;
                this.OnPropertyChanged();
            }
        }
    }
}
