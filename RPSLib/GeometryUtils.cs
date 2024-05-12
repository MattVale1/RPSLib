/* Author:			Matthew Vale
 * Role:					Lead Game Developer
 * Company:		Red Phoenix Studios
*/

using UnityEngine;

namespace RPS {

    public class GeometryUtils {

        public class Visibility {

            /// <summary>
            /// Given a Vector3 point, is that point currently visible to the camera?
            /// </summary>
            public bool IsTargetVisible(Camera camera, Vector3 objectPos) {
                var planes = GeometryUtility.CalculateFrustumPlanes(camera);
                foreach (var plane in planes) {
                    if (plane.GetDistanceToPoint(objectPos) < 0)
                        return false;
                }
                return true;
            }

        }

    }

}