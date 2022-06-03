using GameSceneControl.Services;

namespace GameSceneControl.Rooms.Serialization {
    ///DOLATER <summary>add description for class: ServiceData</summary>
    public partial class ServiceData {
        /// <summary>Creates a new instance of <see cref="ServiceData"/></summary>
        public ServiceData() {
            //TODO Fill Constructor for class: ServiceData
        }

        /// <summary>Creates a new instance of <see cref="ServiceData"/></summary>
        /// <param name="service">The service to copy data from</param>
        public ServiceData(IService service) {
            this.FromService(service);
        }
    }
}
