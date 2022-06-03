namespace GameSceneControl {
    public static partial class DataStorage {
        /// <summary>Returns all aviable files in the data storage</summary>
        /// <returns>An array of files</returns>
        public static String[] GetFiles() {
            return InternalGetFiles(DataStorage.RootFolder);
        }

        /// <summary>Returns all aviable files in the folder and subfolders</summary>
        /// <param name="Subdirectory">The subdirectory to start in</param>
        /// <returns>An array of files</returns>
        public static String[] GetFiles(String Subdirectory) {
            return InternalGetFiles(Path.Join(DataStorage.RootFolder, Subdirectory));
        }

        /// <summary>Returns all aviable files in the folder and subfolders</summary>
        /// <param name="Folder">The folder to start the search from</param>
        /// <returns>An array of files</returns>
        private static String[] InternalGetFiles(String Folder) {
            Directory.CreateDirectory(Folder);

            return Directory.GetFiles(Folder, "*", SearchOption.AllDirectories);
        }

        /// <summary>Returns all folders</summary>
        /// <returns></returns>
        public static String[] GetFolder() {
            return InternalGetFolder(DataStorage.RootFolder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static String[] GetFolder(String Subdirectory) {
            return InternalGetFolder(Path.Join(DataStorage.RootFolder, Subdirectory));
        }

        private static String[] InternalGetFolder(String Folder) {
            Directory.CreateDirectory(Folder);

            return Directory.GetDirectories(Folder);
        }
    }
}
