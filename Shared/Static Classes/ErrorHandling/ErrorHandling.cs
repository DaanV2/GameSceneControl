namespace GameSceneControl {
    ///DOLATER <summary>add description for class: ErrorHandling</summary>
    public static partial class ErrorHandling {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="Title"></param>
        /// <param name="Message"></param>
        public static void HandleError(Exception ex, String Title, String Message) {
            //If we cant display it, then we need to just keep throwing it
            if (Shell.Current is null) throw ex;

#if DEBUG
            Shell.Current.DisplayAlert($"Error: {Message}", $"{Message}\n{ex.Message}\n{ex.StackTrace}", "ok");

            if (ex.InnerException is not null) HandleError(ex.InnerException, "Inner Exception", "This is an inner exception");
#else
            Shell.Current.DisplayAlert(Title, $"{Message}\n{ex.Message}", "ok");
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exceptions"></param>
        /// <param name="Title"></param>
        /// <param name="Message"></param>
        public static void HandleError(AggregateException exceptions, String Title, String Message) {
            foreach (Exception ex in exceptions.InnerExceptions) {
                HandleError(ex, Title, Message);
            }
        }
    }
}
