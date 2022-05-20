namespace GameSceneControl {
    public static partial class DataStorage {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string[] GetFiles() {
            return InternalGetFiles(DataStorage.RootFolder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string[] GetFiles(string Subdirectory) {
            return InternalGetFiles(Path.Join(DataStorage.RootFolder, Subdirectory));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        private static string[] InternalGetFiles(string Folder) {
            return Directory.GetFiles(Folder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string[] GetFolder() {
            return InternalGetFiles(DataStorage.RootFolder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string[] GetFolder(string Subdirectory) {
            return InternalGetFolder(Path.Join(DataStorage.RootFolder, Subdirectory));
        }

        private static string[] InternalGetFolder(string Folder) {
            return Directory.GetDirectories(Folder);
        }
    }
}
