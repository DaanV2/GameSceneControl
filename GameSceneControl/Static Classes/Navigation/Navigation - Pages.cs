namespace GameSceneControl {
    ///DOLATER <summary>add description for class: Navigation</summary>
    public static partial class Navigation {
        /// <summary>Performs the navigation to a page</summary>
        /// <param name="page">The page to navigate to</param>
        public static void GotoPage(Page page) {
            Task Request = Shell.Current.Navigation.PushAsync(page);

            HandleRequest(Request);
        }

        /// <summary>Performs the navigation to a page</summary>
        /// <param name="page">The page to navigate to</param>
        /// <param name="animated"></param>
        public static void GotoPage(Page page, Boolean animated) {
            Task Request = Shell.Current.Navigation.PushAsync(page, animated);

            HandleRequest(Request);
        }
    }
}
