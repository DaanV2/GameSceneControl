using GameSceneControl.Services;

namespace GameSceneControl.Rooms {
    ///DOLATER <summary>add description for class: Room</summary>
    public partial class Room {
        /// <summary>Creates a new instance of <see cref="Room"/></summary>
        public Room() {
            this.Services = new List<IService>();
            this.Lamps = new List<Lamp>();
        }
    }
}
