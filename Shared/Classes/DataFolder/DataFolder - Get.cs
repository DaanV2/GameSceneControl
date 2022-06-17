using System.Diagnostics;

namespace GameSceneControl {
    public partial class DataFolder {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public (Boolean, T) Get<T>(String Filename) {
            String Filepath = Path.Join(this.RootFolder, Filename);
            return this.Load<T>(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="Subdirectory"></param>
        /// <returns></returns>
        public (Boolean, T) Get<T>(String Filename, String Subdirectory) {
            String Folder = Path.Join(this.RootFolder, Subdirectory);
            _ = Directory.CreateDirectory(Folder);

            String Filepath = Path.Join(Folder, Filename);
            return this.Load<T>(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public (Boolean, T) Load<T>(String Filepath) {
            T result = default;
            Boolean success;
            Stream Reader = null;

            try {
                Reader = new FileStream(Filepath, FileMode.Open);
                result = System.Text.Json.JsonSerializer.Deserialize<T>(Reader);
                success = true;
            }
            catch (Exception ex) {
                success = false;
                Debug.WriteLine(ex?.Message);
            }

            if (Reader != null) {
                Reader.Close();
            }

            return (success, result);
        }
    }
}
