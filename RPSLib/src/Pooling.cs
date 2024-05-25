/* Author:		Matthew Vale
 * Role:		Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using UnityEngine;

namespace RPS {

    public class Pooling {

        /// <summary>
        /// Pool X GameObject N times with an optional parent Transform.
        /// </summary>
        /// <returns>The list of pooled objects.</returns>
        public static GameObject[] PoolGameObjects(GameObject baseObject, int amountToPool, Transform? parent = null) {
            GameObject[] objectsToReturn = new GameObject[amountToPool];

            for (int i = 0; i < amountToPool; i++) {
                objectsToReturn[i] = Object.Instantiate(baseObject, parent);
                objectsToReturn[i].SetActive(false);
            }

            return objectsToReturn;
        }

        /// <summary>
        /// Get the next available object from a given pool.
        /// </summary>
        public static GameObject? GetNextObjectInPool(GameObject[] pooledObjects) {
            for (int i = 0; i < pooledObjects.Length; i++) {
                // If the pooled object is not active, we can use it
                if (!pooledObjects[i].activeInHierarchy) {
                    return pooledObjects[i];
                }
            }

            return null;
        }

    }

}