/* Author:		Matthew Vale
 * Role:		Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using UnityEngine;

namespace RPS {

    /// <summary>
    /// For all things LineRenderer!
    /// </summary>
    public class LineRenderingUtils {

        public class LineRendering {

            /// <summary>
            /// Takes a simple 2-point line renderer and draws it.
            /// </summary>
            public static void SetPositionsOfLineRenderer(LineRenderer lr, Vector3 startPos, Vector3 endPos) {
                lr.SetPosition(0, startPos);
                lr.SetPosition(1, endPos);
            }

        }

    }

}