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
ghostBuilding = RPS.PhysicsUtils.Raycast.GetGameObjectAtMousePositionUsingRay(rayDistance, buildingMask, mainCamera);

// Returns a float value representing the distance between 2 objects, using square root.
inspectedDistance = RPS.MathsUtils.Distances.GetOptimizedDistance(fromPos, houses[i].transform.position);
```

# Class list and functions:
| Class  | Description |
| ------------- | ------------- |
| Debug  | For console logging with custom styles. |
| GemoetryUtils  | Checking if mesh is visible. |
| LineRenderingUtils  | For performing various actions with LineRenderers. |
| MathsUtils  | Various maths functions. Currently distance checks and curves. |
| PhysicsUtils  | Raycasting related functions, including getting GameObject at mouse. |
| Pooling | For object pooling. Returns a list of pooled objects.
| Utils  | Uncategorised helpers. Will likely move them into specific classes soon. |
