using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for interface: IActuatorLight</summary>
    public interface IActuatorLight : IActuator {
        /// <summary>Sets this actuator to the given color / brightness or other patterns</summary>
        /// <returns>True of false is the event was send</returns>
        public Boolean SetLight();
    }
}
