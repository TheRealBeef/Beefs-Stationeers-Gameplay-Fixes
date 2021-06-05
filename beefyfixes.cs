using BepInEx;
using HarmonyLib;

namespace BeefyFixes
{
    [BepInPlugin("org.bepinex.plugins.beeffixes", "Beef's Gameplay Fixes", "0.1")]
    [BepInProcess("rocketstation.exe")]
    public class BeefyFixesPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogInfo("Initialized");
            var harmony = new Harmony("org.bepinex.plugins.beeffixes");
            BFConfig.Bind(this);
            harmony.PatchAll();
            Logger.LogInfo("Patched with Harmony");
        }

    }
    public static class BFConfig
    {
        public static float MaxSpeed = 24.0f;
        public static float MotorPower = 40.0f;
        public static float BrakePower = 10.0f;
        public static float MaxNutritionStorage = 40.0f;
        public static float MaxHydrationStorage = 30.0f;
        public static void Bind(BeefyFixesPlugin bf)
        {
            MaxSpeed = bf.Config.Bind("General", "MaxSpeed", 24.0f, "Vanilla value is 3.0").Value;
            MotorPower = bf.Config.Bind("General", "MotorPower", 40.0f, "Vanilla value is 20.0").Value;
            BrakePower = bf.Config.Bind("General", "BrakePower", 10.0f, "Vanilla value is 5.0").Value;
            MaxNutritionStorage = bf.Config.Bind("General", "MaxNutritionStorage", 40.0f, "Vanilla value is 5.0").Value;
            MaxHydrationStorage = bf.Config.Bind("General", "MaxHydrationStorage", 30.0f, "Vanilla value is 5.0").Value;
        }
    }
}
