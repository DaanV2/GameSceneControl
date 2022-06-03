using GameSceneControl.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Hue {
    public partial class PhillipsHueService : IService {
        /// <inheritdoc/>
        public StringDictionary Context => throw new NotImplementedException();

        /// <inheritdoc/>
        public String ID { get; private set; }

        /// <inheritdoc/>
        public List<IActuator> GetActuators() {
            throw new NotImplementedException();
        }
    }
}
