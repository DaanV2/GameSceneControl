using System.Diagnostics;

namespace GameSceneControl {
    public static partial class Navigation { 
        /// <summary>Handles possible errors thrown durring the page creation, only done during debug</summary>
        /// <param name="request"></param>
        [Conditional("DEBUG")]
        private static void HandleRequest(Task request) {
            _ = request.ContinueWith((t) => {
                if (t.IsFaulted) {
                    ErrorHandling.HandleError(t.Exception, "Page Nagivation", "An error occured during page navigation");
                }
            });
        }
    }
}
