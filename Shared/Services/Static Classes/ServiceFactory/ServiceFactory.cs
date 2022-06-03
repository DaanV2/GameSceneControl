using System.Collections.Specialized;

namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for class: ServiceFactory</summary>
    public static partial class ServiceFactory {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static IService CreateService(StringDictionary context) {
            String type = context["type"];
            switch (type) {
#if PhillipsHue
                case "PhillipsHue":
                    
#endif
                case null:
                default:
                    throw new ArgumentException("Unknown service type: " + type);
            }
        }
    }
}
