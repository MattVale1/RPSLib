# RPSLib DLL:
A small (but growing) collection of common code that is used throughout all of my Unity projects. The idea is to:
- Save time re-writing the same code each project or in various classes.
- Provide optimized code for common operations, aiding in high performance for runtime.
- Provide easy to use methods for more complex algorithms.

ℹ️ Most of the classes are currently Utility classes; Commonly used code that can be accessed from anywhere in your project.

# RPSLib.unitypackage:
A Unity package called "RPSLib" is also included in this repo, this contains various scripts, prefabs, render pipeline configs, intro scene and artwork. This package actually contains a LOT more useful code. Such as inventory management, itemisation, quests and more...

⚠️ The Red Phoenix Studios logo included in the Unity package is **NOT** for reuse or modification.

⚠️ A third-party asset is included in this package, "LeanTween". This is the free edition and should also not be redistributed. Credit to [LeanTween](https://assetstore.unity.com/packages/tools/animation/leantween-3595) by [dentedpixel](https://github.com/dentedpixel/LeanTween)

# Installation:
Create a release build of the project, this will produce a RPS.dll and RPS.xml file, simply copy/paste these file into your Unity project.
Or, you can use the files provided in the bin.
The RPS.unitypackage can also simply be dropped into your project. 

# Usage:
Within your code, you can access the DLL by simply typing `RPS.` and then the class you require, or by importing RPS at the top of your file with `using RPS;`.
### Examples:
```
// Returns a GameObject at the mouse position.
clickedObject = RPS.PhysicsUtils.Raycast.GetGameObjectAtMousePosition(rayDistance, buildingMask, mainCamera);

// Returns a float value representing the distance between 2 objects, using square magnitude.
inspectedDistance = RPS.MathsUtils.Distances.GetFastDistance(fromPos, toPos);

// If we loaded the current scene Additively, go back to the previous scene and set it as the active scene.
RPS.SceneManagement.NavigateSceneBack(true);

// Take a screenshot with some optional params (file name, include DateTime, hide UI, file extension and debug logging.
RPS.ScreenshotHandler.TakeScreenshot("Screenshot", true, true, RPS.ScreenshotHandler.FileExtension.PNG, true);
```

# Class list and functions:
| Class  | Description |
| ------------- | ------------- |
| Debug  | For console logging with custom styles. |
| GeometryUtils  | Checking if mesh is visible. |
| LineRenderingUtils  | For performing various actions with LineRenderers. |
| MathsUtils  | Various maths functions. Currently distance checks and curves. |
| PhysicsUtils  | Raycasting related functions, including getting GameObject at mouse. |
| Pooling | For object pooling. Returns/iterates a list of pooled objects.
| SceneManagement | For more complex scene handling. Including Additive scene loading and a back stack for navigating to previously loaded scenes.
| ScreenshotHandler | For capturing screenshots in-game. Offers optional file formats, custom filename and the option to hide all UI while capturing. |
| Utils  | Uncategorised helpers. Will likely move them into specific classes soon. |
