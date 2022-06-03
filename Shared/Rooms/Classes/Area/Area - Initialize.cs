using System.Numerics;

namespace GameSceneControl.Rooms {
    ///DOLATER <summary>add description for class: Area</summary>
    public partial class Area {
        /// <summary>
        /// 
        /// </summary>
        public Area() {
            this.Center = Vector2.Zero;
            this.Parameters = Array.Empty<Single>();
            this.Type = AreaType.Sphere;
        }
    }
}
