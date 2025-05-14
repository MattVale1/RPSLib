/// ------------------------------
/// Original Author: Matthew Vale
/// ------------------------------

using UnityEngine;

namespace RPSLib
{

    /// <summary>
    /// Gemoetry class to handle various geometric calculations.
    /// </summary>
    public class Geometry
    {

        /// <summary>
        /// Provides methods for determining the visibility of objects relative to a camera's view frustum.
        /// </summary>
        public class Visibility
        {

            /// <summary>
            /// Given a Vector3 point, is that point currently visible to the camera?
            /// </summary>
            public static bool IsTargetVisible(Camera camera, Vector3 objectPos)
            {
                var planes = GeometryUtility.CalculateFrustumPlanes(camera);
                foreach (var plane in planes)
                {
                    if (plane.GetDistanceToPoint(objectPos) < 0)
                    {
                        return false;
                    }
                }

                return true;
            }

        }

    }

}