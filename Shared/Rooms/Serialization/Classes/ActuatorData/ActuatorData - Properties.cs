﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms.Serialization {
    public partial class ActuatorData {
        /// <summary>
        /// 
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ServiceID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Area RoomSetup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public StringDictionary Settings { get; set; }
    }
}