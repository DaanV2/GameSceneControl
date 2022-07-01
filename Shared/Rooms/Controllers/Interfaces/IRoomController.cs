using GameSceneControl.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms.Controllers {
    ///DOLATER <summary>add description for interface: IRoomController</summary>
    public interface IRoomController {
        /// <summary>
        /// 
        /// </summary>
        public ControllerState State { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<ActiveService> Services { get; }

        /// <summary>
        /// 
        /// </summary>
        public void Start();

        /// <summary>
        /// 
        /// </summary>
        public void Stop();

        /// <summary>
        /// 
        /// </summary>
        public RoomInfo RoomInfo { get; }
    }
}
