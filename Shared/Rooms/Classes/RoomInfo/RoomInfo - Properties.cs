namespace GameSceneControl.Rooms {
    public partial class RoomInfo : IIdentifiable {
        /// <inheritdoc/>
        public String ID { get; private set; }

        /// <summary></summary>
        public String Name { get; private set; }

        /// <summary></summary>
        public String Description { get; private set; }
    }
}
