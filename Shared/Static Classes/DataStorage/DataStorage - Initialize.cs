namespace GameSceneControl {
    ///DOLATER <summary>add description for class: DataStorage</summary>
    public static partial class DataStorage {
        public static void Initialize() {
            DataStorage.App = new DataFolder(FileSystem.AppDataDirectory);
            DataStorage.Cache = new DataFolder(FileSystem.CacheDirectory);
        }
    }
}