/// ------------------------------
/// Original Author: Matthew Vale
/// ------------------------------

using System;
using UnityEngine;

namespace RPSLib
{
    /// <summary>
    /// Various helpers for manipulating time.
    /// </summary>
    public class Time
    {

        /// <summary>
        /// Sets the time scale.
        /// </summary>
        [Obsolete("Use Time.timeScale instead of routing the same thing through RPSLib.")]
        public static void SetTimeScale(float value)
        {
            UnityEngine.Time.timeScale = value;
        }

        // TODO: Test this function and decide if you should remove it.
        /// <summary>
        /// Smoothly interpolates towards a target time scale. Run this outside Update functions.
        /// </summary>
        [Obsolete("Because this is in a while loop, it might not run separately and hang the thread until done.")]
        public static void LerpTimeScale(float from, float to, float atSpeedOf)
        {
            while (UnityEngine.Time.timeScale != to)
            {
                UnityEngine.Time.timeScale = Mathf.MoveTowards(from, to, atSpeedOf) * UnityEngine.Time.unscaledDeltaTime;
            }
        }

        // TODO: Remove the "V2" from the method name when we confirm if the original method works.
        /// <summary>
        /// Smoothly interpolates towards a target time scale. Run this inside Update function.
        /// </summary>
        public static void LerpTimeScaleV2(float from, float to, float atSpeedOf)
        {
            UnityEngine.Time.timeScale = Mathf.MoveTowards(from, to, atSpeedOf) * UnityEngine.Time.unscaledDeltaTime;
        }

    }
}