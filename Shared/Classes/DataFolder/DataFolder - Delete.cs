using System.Diagnostics;

namespace GameSceneControl {
    public partial class DataFolder {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public  Boolean Delete(String Filename) {
            String Filepath = Path.Join(this.RootFolder, Filename);
            return DeleteFile(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filename"></param>
        /// <param name="Subdirectory"></param>
        /// <returns></returns>
        public  Boolean Delete(String Filename, String Subdirectory) {
            String Folder = Path.Join(this.RootFolder, Subdirectory);
            if (!Directory.Exists(Folder)) return true;

            String Filepath = Path.Join(Folder, Filename);

            return DeleteFile(Filepath);
        }

        public Boolean DeleteFile(String Filepath) {
            Boolean success = false;

            try {
                System.IO.File.Delete(Filepath);
                success = true;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex?.Message);
            }

            return success;
        }

        public Boolean DeleteFolder(String SubFolder) {
            String Folder = Path.Join(this.RootFolder, SubFolder);
            Boolean success = false;

            try {
                System.IO.Directory.Delete(Folder, true);
                success = true;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex?.Message);
            }

            return success;
        }
    }
}
