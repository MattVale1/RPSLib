/* Author:		Matthew Vale
 * Role:		Lead Game Developer
 * Company:		Red Phoenix Studios
*/
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace RPS {

    /// <summary>
    /// Handles taking screenshots of the game. Saves screenshots to user desktop.
    /// </summary>
    public class ScreenshotHandler {

        #region File paths
        private static readonly string _saveFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private static string _screenshotName = "Screenshot";
        private static bool _addExtension_SystemTime = true;
        private static FileExtension _fileExtension = FileExtension.PNG;
        public enum FileExtension { PNG, JPG }
        #endregion

        #region UI states
        private static bool _hideUI = false;
        private static List<Canvas> _sceneCanvasList = new List<Canvas>();
        private static Dictionary<Canvas, bool> _canvasesAndStates = new Dictionary<Canvas, bool>();
        private static bool _canvasToggleState = true;
        #endregion

        #region Screenshot state
        private delegate void ScreenshotCompleteCallback(bool result);
        private static bool _screenshotProcessRunning = false;
        private static bool _showDebug = false;
        #endregion


        /// <summary>
        /// Take a screenshot of the game window and save to user desktop.
        /// </summary>
        /// <param name="screenshotName">Custom name for the screenshot.</param>
        /// <param name="includeTime">Add a date time extension to the end of the file name.</param>
        /// <param name="hideUI">Hide in-game UI?</param>
        /// <param name="fileExtension">File extension to use. PNG or JPG.?</param>
        /// <param name="showDebug">Print helpful Debugs to assist errors.</param>
        public static void TakeScreenshot(string screenshotName, bool includeTime = false, bool hideUI = false, FileExtension fileExtension = FileExtension.PNG, bool showDebug = false) {
            if (_screenshotProcessRunning && _showDebug) {
                Debug.Log("ScreenshotHandler :: Screenshot process already running...", Debug.Style.Warning);
                return;
            }

            _screenshotName = screenshotName;
            _addExtension_SystemTime = includeTime;
            _hideUI = hideUI;
            _fileExtension = fileExtension;
            _showDebug = showDebug;

            ProcessScreenshot((result) => OnScreenshotTaken(result));
        }

        private static void ProcessScreenshot(ScreenshotCompleteCallback callback) {
            _screenshotProcessRunning = true;

            // Hide UI?
            if (_hideUI)
                ToggleUI(false);

            // Run a quick File check.
            if (!Directory.Exists(_saveFileLocation)) {
                Debug.Log("ScreenshotHandler :: Screenshot directory doesn't exist: " + _saveFileLocation, Debug.Style.CriticalError, true);
                return;
            }

            // Generate the full file path string
            string screenshotFullFilePath = Path.Combine(_saveFileLocation, _screenshotName);

            if (_addExtension_SystemTime)
                screenshotFullFilePath += "_" + DateTime.Now.ToFileTime();

            screenshotFullFilePath += "." + _fileExtension;

            // Take the screenshot
            ScreenCapture.CaptureScreenshot(screenshotFullFilePath, 1);
            if (_showDebug)
                Debug.Log("ScreenshotHandler :: Screenshot captured at: " + screenshotFullFilePath, Debug.Style.Success);

            // Show UI?
            if (_hideUI)
                ToggleUI(true);

            callback?.Invoke(true);

        }

        private static void ToggleUI(bool state) {
            _canvasToggleState = state;

            if (!_canvasToggleState) {
                _sceneCanvasList.Clear();
                _sceneCanvasList.AddRange(UnityEngine.Object.FindObjectsByType<Canvas>(FindObjectsSortMode.None));

                _canvasesAndStates.Clear();
                for (int i = 0; i < _sceneCanvasList.Count; i++) {
                    _canvasesAndStates.Add(_sceneCanvasList[i], _sceneCanvasList[i].enabled);
                    _sceneCanvasList[i].enabled = false;
                }
            } else {
                // Restore canvases to previous state
                foreach (var canvasItem in _canvasesAndStates) {
                    canvasItem.Key.enabled = canvasItem.Value;
                }
            }
        }

        private static void OnScreenshotTaken(bool state) {
            _screenshotProcessRunning = state;
        }
    }

}