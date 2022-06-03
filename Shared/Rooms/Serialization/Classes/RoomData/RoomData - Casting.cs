namespace GameSceneControl.Rooms.Serialization {
    public partial class RoomData {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="room"></param>
        public void FromRoom(Room room) {
            //Convert rooms
            room.Services.ForEach(serv => this.Services.Add(new ServiceData(serv)));

            //Convert lamps
            room.Lamps.ForEach(lamp => this.Actuators.Add(new ActuatorData(lamp)));
        }
    }
}
