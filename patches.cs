using Assets.Scripts.Objects;
using Assets.Scripts.Objects.Entities;
using Assets.Scripts.Vehicles;
using HarmonyLib;

namespace BeefyFixes
{
    [HarmonyPatch(typeof(Rover))]
    public static class RoverPatches
    {
        [HarmonyPatch("Awake")]
        [HarmonyPostfix]
        public static void RoverHandlingPatch(Rover __instance)
        {
            Rover Rover = __instance;
            Rover.MaxSpeed = BFConfig.MaxSpeed;
            Rover.MotorPower = BFConfig.MotorPower;
            Rover.BrakePower = BFConfig.BrakePower;
        }
    }

    [HarmonyPatch(typeof(Human))]
    public static class HumanPatches
    {
        [HarmonyPatch("Awake")]
        [HarmonyPostfix]
        static public void HungerHydrationPatch(Human __instance)
        {
            Entity Player = __instance;
            Player.MaxNutritionStorage = BFConfig.MaxNutritionStorage;
            Human.MaxHydrationStorage = BFConfig.MaxHydrationStorage;
        }
    }
}
