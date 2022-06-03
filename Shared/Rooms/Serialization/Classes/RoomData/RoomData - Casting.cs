namespace GameSceneControl.Rooms.Serialization {
    public partial class RoomData {
        public void FromRoom(Room room) {
            room.Services.ForEach(serv => this.Services.Add(new ServiceData(serv)));
        }
    }
}
