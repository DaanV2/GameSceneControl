namespace GameSceneControl.Rooms {
    public static partial class Controller {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static RoomInfo GetInfo(String ID) {
            (Boolean ok, RoomInfo info) = DataStorage.App.Get<RoomInfo>(InfoFileName, Path.Join(RoomFolder, ID));

            return ok ? info : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<RoomInfo> GetRooms() {
            String[] files = DataStorage.App.GetFiles(RoomFolder);
            var result = new List<RoomInfo>(files.Length / 2);

            foreach (String infoFile in files) {
                //If not info then continu to the next one
                if (!infoFile.EndsWith(InfoFileName)) continue;

                (Boolean ok, RoomInfo info) = DataStorage.App.Load<RoomInfo>(infoFile);
                if (ok) result.Add(info);
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Info"></param>
        public static Boolean Store(this RoomInfo Info) {
            return DataStorage.App.Set(InfoFileName, Path.Join(RoomFolder, Info.ID), Info);
        }
    }
}
