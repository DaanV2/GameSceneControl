using GameSceneControl.Services;
using System.Collections.ObjectModel;

namespace GameSceneControl.Rooms.Controllers {
    ///DOLATER <summary>add description for class: LocalController</summary>
    public partial class LocalController {
        /// <summary>Creates a new instance of <see cref="LocalController"/></summary>
        /// <param name="Info"></param>
        public LocalController(RoomInfo Info) {
            this.RoomInfo = Info;
            this.State = ControllerState.Stopped;
            this.Services = new ObservableCollection<ActiveService>();
        }
    }
}
