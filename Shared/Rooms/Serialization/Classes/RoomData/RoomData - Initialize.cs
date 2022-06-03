namespace GameSceneControl.Rooms.Serialization {
    ///DOLATER <summary>add description for class: RoomData</summary>
    public partial class RoomData {
        /// <summary>Creates a new instance of <see cref="RoomData"/></summary>
        public RoomData() {
            this.Services = new List<ServiceData>();
            this.Actuators = new List<ActuatorData>();
        }
    }
}
