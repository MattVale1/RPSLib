/* Author:		Matthew Vale
 * Role:		Lead Game Developer
 * Company:		Red Phoenix Studios
*/
namespace RPSLib {

    /// <summary>
    /// Class to handle console printing with various styles.
    /// </summary>
    public class Debug {

        /// <summary>
        /// Various styling types.
        /// </summary>
        public enum Style {
            Normal,
            Success,
            Warning,
            Error,
            CriticalError
        }

        /// <summary>
        /// Log something to the console using a specific style.
        /// </summary>
        /// <param name="message">The message to print.</param>
        /// <param name="style">The style to use.</param>
        /// <param name="pauseEditor">Should we pause the Unity Editor for this error?</param>
        public static void Log(string message, Style style = Style.Normal, bool pauseEditor = false) {
            switch (style) {
                case Style.Normal:
                    UnityEngine.Debug.Log(message);
                    break;
                case Style.Success:
                    UnityEngine.Debug.Log("<color=green>" + message + "</color>");
                    break;
                case Style.Warning:
                    UnityEngine.Debug.Log("<color=yellow>" + message + "</color>");
                    break;
                case Style.Error:
                    UnityEngine.Debug.Log("<color=orange>" + message + "</color>");
                    break;
                case Style.CriticalError:
                    UnityEngine.Debug.Log("<color=red>" + message + "</color>");
                    break;
            }

            if (pauseEditor)
                UnityEngine.Debug.Break();
        }

    }

}