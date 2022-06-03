using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for interface: IService</summary>
    public interface IService : IIdentifiable {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<IActuator> GetActuators();
       
        /// <summary>Gets the context data, this is needed to recreate the service from serialization</summary>
        public StringDictionary Context { get; }
    }
}
