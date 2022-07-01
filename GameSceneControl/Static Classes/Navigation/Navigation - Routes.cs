namespace GameSceneControl {
    ///DOLATER <summary>add description for class: Navigation</summary>
    public static partial class Navigation {
        /// <summary>Performs the navigation to a page</summary>
        /// <param name="route">The room name or route to take</param>
        /// <example>nameof(RoomPage)</example>
        /// <example>../../</example>
        public static void GotoPage(String route) {
            Task request = Shell.Current.GoToAsync(route);
            HandleRequest(request);
        }

        /// <summary>Performs the navigation to a page</summary>
        /// <param name="route">The room name or route to take</param>
        /// <param name="parameters">The parameters to pass along to the page</param>
        /// <example>nameof(RoomPage)</example>
        /// <example>../../</example>
        public static void GotoPage(String route, IDictionary<String, Object> parameters) {
            Task request = Shell.Current.GoToAsync(route, parameters);
            Object data = null;

            _ = Shell.Current.GoToAsync("RoomInfo", new Dictionary<String, Object> {
                { "Info", data }
            });
            _ = Shell.Current.GoToAsync("RoomInfo?Info=Example");


            HandleRequest(request);
        }

        /// <summary>Performs the navigation to a page</summary>
        /// <param name="route">The room name or route to take</param>
        /// <param name="parameters">The parameters to pass along to the page</param>
        /// <example>nameof(RoomPage)</example>
        /// <example>../../</example>
        public static void GotoPage(String route, params (String, Object)[] parameters) {
            var dict = new Dictionary<String, Object>(parameters.Length);

            foreach ((String, Object) item in parameters) {
                dict.Add(item.Item1, item.Item2);
            }

            GotoPage(route, dict);
        }
    }
}
