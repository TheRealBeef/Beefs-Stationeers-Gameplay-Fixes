using BepInEx;
using HarmonyLib;

namespace BeefyFixes
{
    [BepInPlugin("org.bepinex.plugins.beefsgameplayfixes", "Beef's Gameplay Fixes", "0.1")]
    [BepInProcess("rocketstation.exe")]
    public class BeefyFixesPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogInfo("Initialized");
            var harmony = new Harmony("org.bepinex.plugins.beefsgameplayfixes");
            BFConfig.Bind(this);
            harmony.PatchAll();
            Logger.LogInfo("Patched with Harmony");
        }

    }
    public static class BFConfig
    {
        public static float MaxSpeed = 24.0f;
        public static float MotorPower = 30.0f;
        public static float BrakePower = 20.0f;
        public static float MaxNutritionStorage = 600.0f;
        public static float MetabolismRate = 0.01f;
        public static float MaxHydrationStorage = 80.0f;
        public static float BaseDehydrationRate = 0.003f;
        public static void Bind(BeefyFixesPlugin bf)
        {
            MaxSpeed = bf.Config.Bind("General", "MaxSpeed", 24.0f, "Vanilla value is 3.0").Value;
            MotorPower = bf.Config.Bind("General", "MotorPower", 30.0f, "Vanilla value is 20.0").Value;
            BrakePower = bf.Config.Bind("General", "BrakePower", 20.0f, "Vanilla value is 5.0").Value;
            MaxNutritionStorage = bf.Config.Bind("General", "MaxNutritionStorage", 600.0f, "Vanilla value is 50.0").Value;
            MetabolismRate = bf.Config.Bind("General", "MetablismRate", 0.01f, "Vanilla value is 0.01").Value;
            MaxHydrationStorage = bf.Config.Bind("General", "MaxHydrationStorage", 80.0f, "Vanilla value is 5.0").Value;
            BaseDehydrationRate = bf.Config.Bind("General", "BaseDehydrationRate", 0.003f, "Vanilla value is 0.006").Value;
        }
    }
}
