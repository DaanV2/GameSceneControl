using GameSceneControl.Services;

namespace GameSceneControl.Rooms.Serialization {
    public partial class ActuatorData {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lamp"></param>
        public void FromLamp(Lamp lamp) {
            IActuatorLight actuator = lamp.Actuator;

            this.ID = actuator.ID;
            this.ServiceID = actuator.Service.ID;
            this.RoomSetup = lamp.Area;
            this.Settings = null; //TODO??
        }
    }
}
