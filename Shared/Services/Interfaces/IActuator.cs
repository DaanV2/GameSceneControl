using GameSceneControl.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for interface: IActuator</summary>
    public interface IActuator : IClosable, IParentService, IIdentifiable {
        /// <summary></summary>
        public ActuatorType ActuatorType { get; }
    }
}
