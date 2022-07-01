using Microsoft.Maui.Controls.PlatformConfiguration;

namespace GameSceneControl {
    ///DOLATER <summary>add description for class: DataStorage</summary>
    public static partial class DataStorage {
        public static void Initialize() {
#if WINDOWS
            String folder = Path.Join(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments), 
                    "GameSceneControl");
            DataStorage.App = new DataFolder(folder);
            DataStorage.Cache = new DataFolder(FileSystem.CacheDirectory);
#else
            DataStorage.App = new DataFolder(FileSystem.AppDataDirectory);
            DataStorage.Cache = new DataFolder(FileSystem.CacheDirectory);
#endif
        }
    }
}