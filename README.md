# What's This?
A (currently) small collection of common code that is used throughout all of my Unity projects. The idea is to:
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

# Current Util classes:
```
GeometryUtils.cs (Object visibility)

LineRenderingUtils.cs (Line Rendering helper)

MathsUtils.cs (Distances, closest objects)

PhysicsUtils.cs (Raycasting)

Utils.cs (uncategorised, probably be removed later)
```
