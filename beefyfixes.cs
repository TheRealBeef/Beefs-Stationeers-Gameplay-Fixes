using System;
using HarmonyLib;
using BepInEx;
using UnityEngine;

namespace BeefyFixes
{
    [BepInPlugin("org.bepinex.plugins.beeffixes", "Beef's Gameplay Fixes", "0.1")]
    [BepInProcess("rocketstation.exe")]
    public class init : BaseUnityPlugin
    {
        void Awake()
        {
            beefyfixes.Awake();
        }
    }

    public class beefyfixes
    {
        // Variable Definitions

        public static void AppendLog(string logdetails)
        {
            UnityEngine.Debug.Log("Beef's Gameplay Fixes - " + logdetails);
        }

        // Awake is called once when both the game and the plug-in are loaded
        public static void Awake()
        {
            //Initialize();

            AppendLog("Initialized");
            var harmony = new Harmony("org.bepinex.plugins.beeffixes");
            harmony.PatchAll();
            AppendLog("Patched with Harmony");
        }
    }
}
