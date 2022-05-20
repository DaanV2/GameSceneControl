using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl
{
    /// <summary>The interface that holds an identification code</summary>
    public interface IIdentifiable {
        /// <summary>The identification of this object</summary>
        public Guid ID { get; }
    }
}
