namespace GameSceneControl {
    ///DOLATER <summary>add description for class: DataStorage</summary>
    public static partial class DataStorage {
        public static void Initialize() {
            string Folder;
#if WINDOWS
            Folder = Path.Join(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "GameSceneControl");
#else
            Folder = Path.Join(Environment.CurrentDirectory);
#endif

            Folder = Path.Join(Folder, "storage");
            Console.WriteLine("starting storage: " + Folder);

            System.IO.Directory.CreateDirectory(Folder);
            DataStorage.RootFolder = Folder;
        }
    }
}
