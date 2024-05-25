/* Author:		Matthew Vale
 * Role:		Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using System.Collections.Generic;
using UnityEngine;

namespace RPS {

    public class MathsUtils {

        public class Distances {

            /// <summary>
            /// Get the distance between 2 positions using square magnitude.
            /// </summary>
            public static float GetFastDistance(Vector3 from, Vector3 to) { return (to - from).sqrMagnitude; }

            /// <summary>
            /// Get the closest GameObject to a point from a List of GameObjects.
            /// </summary>
            /// <param name="from">Point of origin.</param>
            /// <param name="targets">List of possible targets.</param>
            public static GameObject GetClosestGameObject(Vector3 from, List<GameObject> targets) {
                byte closestIndex = 0;
                float minDistSqr = Mathf.Infinity;
                for (int i = 0; i < targets.Count; i++) {
                    float dSqrToTarget = GetFastDistance(targets[i].transform.position, from);
                    if (dSqrToTarget < minDistSqr) {
                        minDistSqr = dSqrToTarget;
                        closestIndex = (byte)i;
                    }
                }
                return targets[closestIndex];
            }

        }

        public class Gradients {

            /// <summary>
            /// Useful for smooth animations. Equation is: 
            /// <code>x / x + 1</code>
            /// See <a href="LINK">https://www.desmos.com/calculator/0mxrzgwqgt</a>
            /// </summary>
            public static float SoftLimit(float x) {
                x = Mathf.Max(x, 0);
                return x / (x + 1);
            }

        }

    }

}