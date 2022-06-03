using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl.Services {
    ///DOLATER <summary>add description for interface: IClosable</summary>
    public interface IClosable {
        /// <summary>Closes this object, meaning any connection or resources are closed and released</summary>
        public void Close();
    }
}
