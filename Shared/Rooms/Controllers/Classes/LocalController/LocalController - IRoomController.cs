using GameSceneControl.Services;
using System.Collections.ObjectModel;

namespace GameSceneControl.Rooms.Controllers {
    public partial class LocalController : IRoomController {

        /// <summary>
        /// 
        /// </summary>
        public ControllerState State { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<ActiveService> Services { get; private set; }
        

        public void Stop() {
            throw new NotImplementedException();
        }
    }
}
