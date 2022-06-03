namespace GameSceneControl.Rooms.Serialization {
    ///DOLATER <summary>add description for class: RoomData</summary>
    public partial class RoomData {
        /// <summary>Creates a new instance of <see cref="RoomData"/></summary>
        public RoomData() {
            this.ID = String.Empty;
            this.Services = new List<ServiceData>();
            this.Actuators = new List<ActuatorData>();
        }

        /// <summary>Creates a new instance of <see cref="RoomData"/></summary>
        /// <param name="ID"></param>
        public RoomData(String ID) : base() {
            this.ID = ID;
        }
    }
}
