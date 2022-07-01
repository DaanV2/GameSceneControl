using GameSceneControl.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms.Controllers {
    public partial class LocalController {
        /// <summary>
        /// 
        /// </summary>
        public void Start() {
            var Data = GameSceneControl.Rooms.Controller.GetData(this.RoomInfo);
        }
    }
}
