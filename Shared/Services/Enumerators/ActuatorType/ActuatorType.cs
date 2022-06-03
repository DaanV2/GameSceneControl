using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for enumerator: ActuatorType</summary>
    [Flags]
    public enum ActuatorType : byte {
        /// <summary></summary>
        Light,
        /// <summary></summary>
        Sound
    }
}
