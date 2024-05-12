/* Author:		    Matthew Vale
 * Role:		            Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using System.Collections.Generic;
using UnityEngine;

namespace RPS {

    public class MathsUtils {

        public class Distances {

            /// <summary>
			/// Get the distance between 2 positions using square root.
			/// </summary>
			public static float GetOptimizedDistance(Vector3 from, Vector3 to) { return (to - from).sqrMagnitude; }

            /// <summary>
			/// Get the closest GameObject to a point from a List of GameObjects.
			/// </summary>
			/// <param name="from">Point of origin.</param>
			/// <param name="targets">List of possible targets.</param>
			public static GameObject GetOptimizedClosestGameObject(Vector3 from, List<GameObject> targets) {
                byte closestIndex = 0;
                float minDistSqr = Mathf.Infinity;
                for (int i = 0; i < targets.Count; i++) {
                    float dSqrToTarget = (targets[i].transform.position - from).sqrMagnitude;
                    if (dSqrToTarget < minDistSqr) {
                        minDistSqr = dSqrToTarget;
                        closestIndex = (byte)i;
                    }
                }
                return targets[closestIndex];
            }
        }

    }

}