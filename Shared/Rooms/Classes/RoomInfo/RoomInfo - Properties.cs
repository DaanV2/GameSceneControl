namespace GameSceneControl.Rooms {
    public partial class RoomInfo : IIdentifiable {
        /// <inheritdoc/>
        public String ID { get; set; }

        /// <summary></summary>
        public String Name { get; set; }

        /// <summary></summary>
        public String Description { get; set; }
    }
}
