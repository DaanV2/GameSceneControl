﻿using GameSceneControl.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms {
    public partial class Lamp {
        /// <summary>
        /// 
        /// </summary>
        public IActuatorLight Actuator { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Area Area { get; private set; }
    }
}
