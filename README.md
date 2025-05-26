# RPSLib.dll:
A growing collection of common code that is used throughout all of my Unity projects. The idea is to:
- Save time re-writing the same code for each project.
- Provide optimized code for common operations, aiding in high performance for runtime.
- Provide easy to use methods for more complex algorithms.

# RPSLib.unitypackage:
This Unity package is also included in this repo and is all you need to use this library. It contains various scripts, prefabs, render pipeline configs, UI elements, a splash scene and more. Some systems included are inventory management, itemisation and ScriptableObject based quests.

⚠️ The Red Phoenix Studios logo included in the Unity package is **NOT** for reuse or modification.

# Third-party packages included:

`LeanTween` This is the free edition and should also not be redistributed. Credit to [LeanTween](https://assetstore.unity.com/packages/tools/animation/leantween-3595) by [dentedpixel](https://github.com/dentedpixel/LeanTween).

`Steamworks.NET` See the [Documentation](https://steamworks.github.io/gettingstarted/) and [GitHub](https://github.com/rlabrecque/Steamworks.NET).

# Installation:
- Install the RPSLib package by dropping `RPSLib.unitypackage` into your project. The package will always contain the latest DLL, so no need to build the project unless you edit the source files. If you do edit the source and make a build, copy the `RPSLib.dll` and `RPSLib.xml` into your project, overriding the existing files.

**Dependencies:**
- Steamworks.NET (included in RPSLib.unitypackage)
- Unity Localization package (please fetch this yourself)

# Usage:
Within your code, you can access the DLL by simply typing `RPSLib.` and then the class you require (like any other library), or by importing RPS at the top of your file with `using RPSLib;`.
### Examples:
```
// Returns a GameObject at the mouse position.
clickedObject = RPSLib.Physics.Raycast.GetGameObjectAtMousePosition(rayDistance, buildingMask, mainCamera);

// Returns a float value representing the distance between 2 objects, using square magnitude.
inspectedDistance = RPSLib.Maths.Distances.GetFastDistance(fromPos, toPos);

// If we loaded the current scene Additively, go back to the previous scene and set it as the active scene.
RPSLib.SceneManagement.NavigateSceneBack(true);

// Take a screenshot with some optional params (file name, include DateTime, hide UI, file extension and debug logging.
RPSLib.ScreenshotHandler.TakeScreenshot("Screenshot", true, true, RPSLib.ScreenshotHandler.FileExtension.PNG, true);
```

# Class list and functions:
| Class | Description |
| ------------- | ------------- |
| Debug | For console printing with various styles. |
| Geometry | For handling various geometric calculations. |
| Graphics | Display and Graphical settings. |
| LineRendering | For performing various actions with LineRenderers. |
| Maths | Various maths functions such as distance checks, weights and curves. |
| Physics | Raycasting related functions, including getting GameObject at mouse. |
| Pooling | For object pooling. Returns/iterates a list of pooled objects.
| SceneManagement | For more complex scene handling. Including Additive scene loading and a back stack for navigating to previously loaded scenes.
| ScreenshotHandler | For capturing screenshots in-game. Offers optional file formats, custom filename and the option to hide all UI while capturing. |
| Time | Time manipulation. |
