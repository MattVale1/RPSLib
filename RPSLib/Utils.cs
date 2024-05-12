/* Author:			Matthew Vale
 * Role:					Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using UnityEngine;

namespace RPS {

	public class Utils {

		/// <summary>
		/// Frame rate and VSync setting.
		/// </summary>
		public class FPSUtil {

            public enum VSyncMode { OFF, ON }

            /// <summary>
            /// Set the Application's target framerate and VSync mode (default ON).
            /// </summary>
            public static void SetFramesPerSecond(int targetFPS, VSyncMode vsync = VSyncMode.ON) {
				Application.targetFrameRate = targetFPS;
            }
			
			/// <summary>
			/// Set the Application's vertical sync mode.
			/// </summary>
			public static void SetVSyncMode(VSyncMode mode) {
				QualitySettings.vSyncCount = (int)mode;
            }
        }

		/// <summary>
		/// Game time manipulation.
		/// </summary>
		public class TimeUtil {

			public static void SetTimeScale(float value) {
				Time.timeScale = value;
            }

			public static void LerpTimeScale(float from, float to, float atSpeedOf) {
				while(Time.timeScale != to) {
					Time.timeScale = Mathf.MoveTowards(from, to, atSpeedOf) * Time.unscaledDeltaTime;
				}				
            }

        }

    }

}