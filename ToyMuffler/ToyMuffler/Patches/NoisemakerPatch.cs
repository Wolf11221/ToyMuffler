using HarmonyLib;

namespace ToyMuffler.Patches
{
    [HarmonyPatch]
    internal class NoisemakerPatch
    {
        [HarmonyPatch(typeof(NoisemakerProp), "ItemActivate")]
        public static void Prefix(ref NoisemakerProp __instance)
        {
            __instance.minLoudness = 0f;
            __instance.maxLoudness = 0f;
        }
    }
}