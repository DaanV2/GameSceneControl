using GameSceneControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms {
    public partial class Room {
        /// <summary>
        /// 
        /// </summary>
        public List<IService> Services { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Lamp> Lamps { get; private set; }
    }
}
