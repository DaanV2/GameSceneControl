using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms {
    ///DOLATER <summary>add description for class: RoomInfo</summary>
    public partial class RoomInfo {
        /// <summary>Creates a new instance of <see cref="RoomInfo"/></summary>
        public RoomInfo() {
            this.Name = String.Empty;
            this.ID = String.Empty;
            this.Description = String.Empty;
        }
    }
}
