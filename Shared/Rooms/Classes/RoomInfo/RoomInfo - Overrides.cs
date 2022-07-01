using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms {
    public partial class RoomInfo : IEquatable<RoomInfo> {
        /// <inheritdoc/>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as RoomInfo);
        }

        /// <inheritdoc/>
        public Boolean Equals(RoomInfo other) {
            return other is not null &&
                   this.ID == other.ID &&
                   this.Name == other.Name &&
                   this.Description == other.Description;
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.ID, this.Name, this.Description);
        }

        /// <inheritdoc/>
        public static Boolean operator ==(RoomInfo left, RoomInfo right) {
            return EqualityComparer<RoomInfo>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static Boolean operator !=(RoomInfo left, RoomInfo right) {
            return !(left == right);
        }
    }
}
