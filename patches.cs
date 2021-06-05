using System;
using HarmonyLib;
using UnityEngine;
using Assets.Scripts.Vehicles;
using UnityStandardAssets.ImageEffects;

namespace Beefy_Fixes
{
    public class PatchConfigs
    {
        public static bool I_Have_A_Strong_PC_And_GPU = true; // Determines whether to use quarter or half resolution, and how many samples.
    }

    // Changes to Rover
    [HarmonyPatch(typeof(Rover), "Awake")]
    public class RoverPatcher
    {
        static void Postfix(Rover __instance)
        {
            Rover RoverPatcher = __instance as Rover;

            RoverPatcher.MaxSpeed = 24.0f; //3.0f original
            RoverPatcher.MotorPower = 40.0f; //20.0f original
            RoverPatcher.BrakePower = 15.0f; //5.0f original
        }
    }
}
