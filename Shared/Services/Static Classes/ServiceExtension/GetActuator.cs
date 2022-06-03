namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for class: ServiceExtension</summary>
    public static partial class ServiceExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Service"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static IActuator GetActuator<T>(this T Service, Guid ID)
            where T : IService {

            var Actuators = Service.GetActuators();
            return Actuators.ById(ID);
        }
    }
}
