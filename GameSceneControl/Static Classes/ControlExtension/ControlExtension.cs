using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSceneControl {
    ///DOLATER <summary>add description for class: ControlExtension</summary>
    public static partial class ControlExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="editor"></param>
        /// <param name="MinimumLength"></param>
        /// <returns></returns>
        public static Boolean HasText<T>(this T editor, Int32 MinimumLength = 1)
            where T : IText {
            if (editor.Text is null) return false;
            if (editor.Text.Length >= MinimumLength) return true;

            return false;
        }
    }
}
