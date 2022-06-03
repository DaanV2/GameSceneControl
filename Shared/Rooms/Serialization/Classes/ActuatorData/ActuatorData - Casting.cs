using GameSceneControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms.Serialization {
    public partial class ActuatorData {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actuator"></param>
        public void FromActuator(IActuator actuator) {
            this.ID = actuator.ID;
            this.ServiceID = actuator.Service.ID;
            this.RoomSetup = actuator.Area;
            this.Settings = null; //TODO??
        }
    }
}
