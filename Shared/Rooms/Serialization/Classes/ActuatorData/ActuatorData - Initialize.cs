using GameSceneControl.Services;

namespace GameSceneControl.Rooms.Serialization {
    ///DOLATER <summary>add description for class: ActuatorData</summary>
    public partial class ActuatorData {
        /// <summary>Creates a new instance of <see cref="ActuatorData"/></summary>
        public ActuatorData() {
            //TODO Fill Constructor for class: ActuatorData
        }

        /// <summary>Creates a new instance of <see cref="ActuatorData"/></summary>
        /// <param name="lamp"></param>
        public ActuatorData(Lamp lamp) {
            this.FromLamp(lamp);
        }
    }
}
