using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for interface: IParentService</summary>
    public interface IParentService {
        /// <summary>Gets the associated <see cref="IService"/> that made this object</summary>
        public IService Service { get; }
    }
}
