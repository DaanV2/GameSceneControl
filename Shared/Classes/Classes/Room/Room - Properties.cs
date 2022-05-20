namespace GameSceneControl.Classes {
    public partial class Room : IIdentifiable {
        /// <inheritdoc/>
        public Guid ID { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Scene> SceneList { get; private set; }
    }
}
