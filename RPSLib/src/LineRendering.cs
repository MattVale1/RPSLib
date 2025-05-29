﻿/// ------------------------------
/// Original Author: Matthew Vale
/// ------------------------------

using UnityEngine;

namespace RPSLib
{

    /// <summary>
    /// For all things LineRenderer!
    /// </summary>
    public class LineRendering
    {

        /// <summary>
        /// Takes a simple 2-point line renderer and draws it.
        /// </summary>
        public static void SetPositionsOfLineRenderer(LineRenderer lr, Vector3 startPos, Vector3 endPos, bool draw = true)
        {
            lr.SetPosition(0, startPos);
            lr.SetPosition(1, endPos);
            lr.enabled = draw;
        }

    }

}