using System.Diagnostics;

namespace GameSceneControl {
    ///DOLATER <summary>Add description for class: DataFolder</summary>
    public partial class DataFolder {
        /// <summary>Creates a new instance of <see cref="DataFolder"/></summary>
        internal DataFolder(String Folder) {
            this.RootFolder = Folder;

            Debug.WriteLine("starting storage: " + Folder);
            _ = System.IO.Directory.CreateDirectory(Folder);
        }
    }
}
