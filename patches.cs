using System;
using HarmonyLib;
using UnityEngine;
using Assets.Scripts.Vehicles;
using Assets.Scripts.Objects;
using UnityStandardAssets.ImageEffects;

namespace Beefy_Fixes
{
    // Changes to Rover
    [HarmonyPatch(typeof(Rover), "Awake")]
    public class RoverPatcher
    {
        static void Postfix(Rover __instance)
        {
            Rover RoverPatcher = __instance as Rover;

            RoverPatcher.MaxSpeed = 24.0f; //3.0f original
            RoverPatcher.MotorPower = 30.0f; //20.0f original
            RoverPatcher.BrakePower = 10.0f; //5.0f original
        }
    }

    // Changes to Rover
    [HarmonyPatch(typeof(Entity), "Awake")]
    public class HungerHydrationPatcher
    {
        static void Postfix(Entity __instance)
        {
            Entity HungerHydrationPatcher = __instance as Entity;
            HungerHydrationPatcher.MaxNutritionStorage = 30.0f; //5.0f original
        }
        static void Postfix()
        {
           Entity.MaxHydrationStorage = 20.0f; //5.0f original
        }
    }
}
