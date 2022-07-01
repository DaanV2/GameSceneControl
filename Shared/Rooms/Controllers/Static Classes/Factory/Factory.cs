namespace GameSceneControl.Rooms.Controllers {
    ///DOLATER <summary>add description for class: Factory</summary>
    public static partial class Factory {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static IRoomController Create(RoomInfo info) {
            var Controller = new LocalController(info);

            //Kick of the starting process and handle any closing / erroring
            _ = Task.Run(Controller.Start).ContinueWith(HandleTask);

            return Controller;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        private static void HandleTask(Task task) {
            if (task is null) return;

            if (task.IsFaulted) {
                ErrorHandling.HandleError(task.Exception, "Room Controller", "An error occured during the room controller");
            }
        }
    }
}
