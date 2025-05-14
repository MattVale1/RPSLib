/// ------------------------------
/// Original Author: Matthew Vale
/// ------------------------------

using UnityEngine;

namespace RPSLib
{
    /// <summary>
    /// 
    /// </summary>
    public class Graphics
    {
        /// <summary>
        /// Display settings such as VSync, FPS and screen resolution.
        /// </summary>
        public class Display
        {

            public enum VSyncMode { OFF, ON }

            /// <summary>
            /// Set the Application's target framerate and VSync mode (default ON).
            /// </summary>
            public static void SetFramesPerSecond(int targetFPS, VSyncMode vsync = VSyncMode.ON)
            {
                if (vsync == VSyncMode.ON)
                {
                    QualitySettings.vSyncCount = 1;
                }
                else
                {
                    QualitySettings.vSyncCount = 0;
                }

                Application.targetFrameRate = targetFPS;
            }

            /// <summary>
            /// Set the Application's vertical sync mode.
            /// </summary>
            public static void SetVSyncMode(VSyncMode mode)
            {
                QualitySettings.vSyncCount = (int)mode;
            }
        }
    }
}