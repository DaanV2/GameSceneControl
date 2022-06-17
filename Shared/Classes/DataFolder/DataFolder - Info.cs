namespace GameSceneControl {
    public partial class DataFolder {
        /// <summary>Returns all aviable files in the data storage</summary>
        /// <returns>An array of files</returns>
        public String[] GetFiles() {
            return this.InternalGetFiles(this.RootFolder);
        }

        /// <summary>Returns all aviable files in the folder and subfolders</summary>
        /// <param name="Subdirectory">The subdirectory to start in</param>
        /// <returns>An array of files</returns>
        public String[] GetFiles(String Subdirectory) {
            return this.InternalGetFiles(Path.Join(this.RootFolder, Subdirectory));
        }

        /// <summary>Returns all aviable files in the folder and subfolders</summary>
        /// <param name="Folder">The folder to start the search from</param>
        /// <returns>An array of files</returns>
        private String[] InternalGetFiles(String Folder) {
            _ = Directory.CreateDirectory(Folder);

            return Directory.GetFiles(Folder, "*", SearchOption.AllDirectories);
        }

        /// <summary>Returns all folders</summary>
        /// <returns></returns>
        public String[] GetFolder() {
            return this.InternalGetFolder(this.RootFolder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String[] GetFolder(String Subdirectory) {
            return this.InternalGetFolder(Path.Join(this.RootFolder, Subdirectory));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        private String[] InternalGetFolder(String Folder) {
            _ = Directory.CreateDirectory(Folder);

            return Directory.GetDirectories(Folder);
        }
    }
}
