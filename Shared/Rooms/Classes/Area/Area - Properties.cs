using System.Numerics;

namespace GameSceneControl.Rooms {
    public partial class Area {
        /// <summary>
        /// 
        /// </summary>
        public AreaType Type { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Vector2 Center { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Single[] Parameters { get; private set; }
    }
}
