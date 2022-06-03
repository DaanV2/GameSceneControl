namespace GameSceneControl.Rooms.Serialization {
    public partial class RoomData {
        /// <summary>
        /// 
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ServiceData> Services { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ActuatorData> Actuators { get; set; }


        //TODO scenes
        //TODO mutators
    }
}
