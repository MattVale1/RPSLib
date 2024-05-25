/* Author:		Matthew Vale
 * Role:        Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using UnityEngine;

namespace RPS {

    public class PhysicsUtils {

        public class Raycast {

            /// <summary>
            /// Get a reference to the GameObject at the mouse position using a raycast.
            /// </summary>
            public static GameObject? GetGameObjectAtMousePosition(float rayDistance, LayerMask maskToCheck, Camera? sourceCamera = null) {
                Ray ray;

                if (sourceCamera == null) {
                    if (Camera.main == null) {
                        Debug.Log("No Camera in scene! Set a Main Camera or pass one into this method.", DebugStyle.CriticalError, true);
                        return null;
                    }
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                } else {
                    ray = sourceCamera.ScreenPointToRay(Input.mousePosition);
                }

                if (Physics.Raycast(ray, out RaycastHit rayHit, rayDistance, maskToCheck)) {
                    return rayHit.transform.gameObject;
                }

                return null;
            }

        }

    }

}