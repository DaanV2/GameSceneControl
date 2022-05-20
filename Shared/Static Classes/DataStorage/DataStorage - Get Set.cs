namespace GameSceneControl {
    public static partial class DataStorage {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public static (bool, T) Get<T>(string Filename) {
            var Filepath = Path.Join(DataStorage.RootFolder, Filename);
            return InternalGet<T>(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="Subdirectory"></param>
        /// <returns></returns>
        public static (bool, T) Get<T>(string Filename, string Subdirectory) {
            var Filepath = Path.Join(DataStorage.RootFolder, Subdirectory, Filename);
            return InternalGet<T>(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        private static (bool, T) InternalGet<T>(string Filepath) {
            T result = default;
            bool success = false;
            Stream Reader = null;

            try {
                Reader = new FileStream(Filepath, FileMode.Open);
                result = System.Text.Json.JsonSerializer.Deserialize<T>(Reader);
            }
            catch (Exception ex) {
                success = false;
                Console.WriteLine(ex?.Message);
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
        public static Boolean Set<T>(string Filename, T value) {
            var Filepath = Path.Join(DataStorage.RootFolder, Filename);
            return InternalSet<T>(Filepath, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filename"></param>
        /// <param name="Subdirectory"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean Set<T>(string Filename, string Subdirectory, T value) {
            var Filepath = Path.Join(DataStorage.RootFolder, Subdirectory, Filename);
            return InternalSet<T>(Filepath, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Filepath"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static Boolean InternalSet<T>(string Filepath, T value) {
            bool success = false;
            Stream Writer = null;

            try {
                Writer = new FileStream(Filepath, FileMode.Create);
                System.Text.Json.JsonSerializer.Serialize<T>(Writer, value);
            }
            catch (Exception ex) {
                success = false;
                Console.WriteLine(ex?.Message);
            }

            if (Writer != null) {
                Writer.Close();
            }

            return success;
        }
    }
}
