using GameSceneControl.Classes.BaseViewModel;
using GameSceneControl.Rooms;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GameSceneControl.Pages.Rooms {
    public partial class RoomsInfoModel : BaseViewModel {
        public ObservableCollection<RoomInfo> Rooms { get; } = new();

        public RoomsInfoModel() {
        }


        public void GetRooms() {
            this.Rooms.Clear();

            foreach (RoomInfo Room in Controller.GetRooms()) {
                this.Rooms.Add(Room);
            }
        }
    }
}
