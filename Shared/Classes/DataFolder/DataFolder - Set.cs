using System.Diagnostics;

namespace GameSceneControl {
    public partial class DataFolder {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean Set<T>(String Filename, T value) {
            String Filepath = Path.Join(this.RootFolder, Filename);
            return this.Save(Filepath, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="Subdirectory"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean Set<T>(String Filename, String Subdirectory, T value) {
            String Folder = Path.Join(this.RootFolder, Subdirectory);
            _ = Directory.CreateDirectory(Folder);

            String Filepath = Path.Join(Folder, Filename);
            return this.Save(Filepath, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filepath"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean Save<T>(String Filepath, T value) {
            Boolean success = false;
            Stream Writer = null;

            try {
                Writer = new FileStream(Filepath, FileMode.Create);
                System.Text.Json.JsonSerializer.Serialize<T>(Writer, value);
                success = true;
            }
            catch (Exception ex) {
                success = false;
                Debug.WriteLine(ex?.Message);
            }

            if (Writer != null) {
                Writer.Close();
            }

            return success;
        }
    }
}
