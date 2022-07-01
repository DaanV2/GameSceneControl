using GameSceneControl.Rooms.Controllers;

namespace GameSceneControl.Pages.Rooms {
    public partial class RoomPageModel : BaseViewModel {
        public void CheckController() {
            //If there is no controller
            if (this.Controller is null ||
                //Is Room info updated?
                !this.Controller.RoomInfo.Equals(this.RoomInfo) ||
                //Is controller healthy?
                this.Controller.State != ControllerState.Running) {

                //Then refresh
                this.RenewController();
            }
        }

        internal void RenewController() {
            this.Controller?.Stop();

            this.Controller = Factory.Create(this.RoomInfo);
        }
    }
}
