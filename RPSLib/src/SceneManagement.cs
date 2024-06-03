/* Author:		    Matthew Vale
 * Role:		        Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using UnityEngine.SceneManagement;

namespace RPS {

    /// <summary>
    /// Various methods to handle scene loading.
    /// </summary>
    public class SceneManagement {



        /// <summary>
        /// Load a given scene and optionally set it active.
        /// </summary>
        public void LoadScene(string sceneName, LoadSceneMode loadMode, bool setActive = false) {
            try {
                SceneManager.LoadScene(sceneName, loadMode);
            } catch {
                Debug.Log("ActiveSceneHandler :: Could not load scene: " + sceneName + ". Does not exist, or is not in build settings.", Debug.Style.CriticalError);
                return;
            }

            if (setActive)
                SetSceneActive(sceneName);
        }

        /// <summary>
        /// Sets a specific scene active. Determines the lighting and which scene new Objects are spawned in.
        /// </summary>
        public void SetSceneActive(string sceneName) {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        }

        /// <summary>
        /// Unload the scene from memory and destroy all GameObjects in that scene.
        /// </summary>
        public void UnloadScene(string sceneName) {
            SceneManager.UnloadSceneAsync(sceneName);
        }

    }

}