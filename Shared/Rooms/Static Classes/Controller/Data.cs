using GameSceneControl.Rooms.Serialization;

namespace GameSceneControl.Rooms {
    public static partial class Controller {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        public static RoomData GetData(this RoomInfo Info) {
            return GetData(Info.ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static RoomData GetData(String ID) {
            (Boolean ok, RoomData info) = DataStorage.App.Get<RoomData>(DataFilename, Path.Join(RoomFolder, ID));

            return ok ? info : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public static Boolean Store(this RoomData Data) {
            return DataStorage.App.Set(DataFilename, Path.Join(RoomFolder, Data.ID), Data);
        }

        public static Boolean Remove(RoomInfo Data) {
            return Remove(Data.ID);
        }

        public static Boolean Remove(String ID) {
            return DataStorage.App.DeleteFolder(Path.Join(RoomFolder, ID));
        }
    }
}
