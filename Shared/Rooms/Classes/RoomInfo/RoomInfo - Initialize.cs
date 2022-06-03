namespace GameSceneControl.Rooms {
    ///DOLATER <summary>add description for class: RoomInfo</summary>
    public partial class RoomInfo {
        /// <summary>Creates a new instance of <see cref="RoomInfo"/></summary>
        public RoomInfo() {
            this.Name = String.Empty;
            this.ID = String.Empty;
            this.Description = String.Empty;
        }

        /// <summary>Creates a new instance of <see cref="RoomInfo"/></summary>
        /// <param name="Name"></param>
        /// <param name="ID"></param>
        /// <param name="Description"></param>
        public RoomInfo(String Name, String ID, String Description) {
            this.Name = Name;
            this.ID = ID;
            this.Description = Description;
        }
    }
}
