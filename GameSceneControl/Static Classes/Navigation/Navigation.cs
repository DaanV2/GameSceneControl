using System.Diagnostics;

namespace GameSceneControl {
    ///DOLATER <summary>add description for class: Navigation</summary>
    public static partial class Navigation {
        public static void GotoPage(String route) {
            Task request = Shell.Current.GoToAsync(route);
            HandleRequest(request);
        }

        public static void GotoPage(String route, IDictionary<String, Object> parameters) {
            Task request = Shell.Current.GoToAsync(route, parameters);
            HandleRequest(request);
        }

        [Conditional("DEBUG")]
        private static void HandleRequest(Task request) {
            _ = request.ContinueWith((t) => {
                if (t.IsFaulted) {
                    AggregateException ex = t.Exception;
                    _ = Shell.Current.DisplayAlert("Error", ex.Message + "\n" + ex.StackTrace, "ok");
                }
            });
        }
    }
}
