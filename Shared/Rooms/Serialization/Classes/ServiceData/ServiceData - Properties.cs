using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Rooms.Serialization {
    public partial class ServiceData : IIdentifiable {
        /// <summary>
        /// 
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public StringDictionary Settings { get; set; }
    }
}
