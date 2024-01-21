﻿using HarmonyLib;

namespace Splotch.Loader
{
    /// <summary>
    /// Runs all of Splotch's patches.
    /// </summary>
    internal static class Patcher
    {
        public static Harmony harmony;
        /// <summary>
        /// Runs all of Splotch's patches.
        /// </summary>
		public static void DoPatching()
        {
            harmony = new Harmony("com.codemob.splotch");
			harmony.PatchAll(typeof(Patches));
		}

        [HarmonyPatch]
        internal static class Patches
        {

        }
    }

}