using System.Diagnostics;

namespace GameSceneControl {
    ///DOLATER <summary>add description for class: DataStorage</summary>
    public static partial class DataStorage {
        public static void Initialize() {
            String Folder = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);

            Folder = Path.Join(Folder, "storage");
            Debug.WriteLine("starting storage: " + Folder);

            _ = System.IO.Directory.CreateDirectory(Folder);
            DataStorage.RootFolder = Folder;
        }
    }
}
