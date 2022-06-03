using System.Diagnostics;

namespace GameSceneControl {
    public static partial class DataStorage {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public static (Boolean, T) Get<T>(String Filename) {
            String Filepath = Path.Join(DataStorage.RootFolder, Filename);
            return Load<T>(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="Subdirectory"></param>
        /// <returns></returns>
        public static (Boolean, T) Get<T>(String Filename, String Subdirectory) {
            String Folder = Path.Join(DataStorage.RootFolder, Subdirectory);
            _ = Directory.CreateDirectory(Folder);

            String Filepath = Path.Join(Folder, Filename);
            return Load<T>(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static (Boolean, T) Load<T>(String Filepath) {
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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean Set<T>(String Filename, T value) {
            String Filepath = Path.Join(DataStorage.RootFolder, Filename);
            return Save<T>(Filepath, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="Subdirectory"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean Set<T>(String Filename, String Subdirectory, T value) {
            String Folder = Path.Join(DataStorage.RootFolder, Subdirectory);
            _ = Directory.CreateDirectory(Folder);

            String Filepath = Path.Join(Folder, Filename);
            return Save<T>(Filepath, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filepath"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean Save<T>(String Filepath, T value) {
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
