# RPSLib:
A small (but growing) collection of common code that is used throughout all of my Unity projects. The idea is to:
- Save time re-writing the same code each project or in various classes.
- Provide optimized code for common operations, aiding in high performance for runtime.
- Provide easy to use methods for more complex algorithms.

Most of the classes are currently Utility classes; Commonly used code that can be accessed from anywhere in your project.

# Installation:
Create a release build of the project, this will produce an RPS.dll file.
You can simply copy/paste this file into your Unity project or use the one provided in the bin.

# Usage:
Within your code, you can access the DLL by simply typing `RPS.` and then the class you require.
### Examples:
```
// Returns a GameObject at the mouse position.
clickedObject = RPS.PhysicsUtils.Raycast.GetGameObjectAtMousePosition(rayDistance, buildingMask, mainCamera);

// Returns a float value representing the distance between 2 objects, using square magnitude.
inspectedDistance = RPS.MathsUtils.Distances.GetFastDistance(fromPos, toPos);

// If we loaded the current scene Additively, go back to the previous scene and set it as the active scene.
RPS.SceneManagement.NavigateSceneBack(true);
```

# Class list and functions:
| Class  | Description |
| ------------- | ------------- |
| Debug  | For console logging with custom styles. |
| GemoetryUtils  | Checking if mesh is visible. |
| LineRenderingUtils  | For performing various actions with LineRenderers. |
| MathsUtils  | Various maths functions. Currently distance checks and curves. |
| PhysicsUtils  | Raycasting related functions, including getting GameObject at mouse. |
| Pooling | For object pooling. Returns/iterates a list of pooled objects.
| SceneManagement | For more complex scene handling. Including Additive scene loading and a back stack for navigating to previously loaded scenes.
| Utils  | Uncategorised helpers. Will likely move them into specific classes soon. |
