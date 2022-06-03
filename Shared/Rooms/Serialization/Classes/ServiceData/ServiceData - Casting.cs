using GameSceneControl.Services;

namespace GameSceneControl.Rooms.Serialization {
    public partial class ServiceData {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public void FromService(IService service) {
            this.ID = service.ID;
            this.Settings = service.Context;
        }
    }
}
