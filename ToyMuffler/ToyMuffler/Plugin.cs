using BepInEx;
using BepInEx.Logging;
using UnityEngine;
using HarmonyLib;

namespace ToyMuffler
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public const string
            MODNAME = "ToyMuffler",
            AUTHOR = "Nie",
            GUID = AUTHOR + "_" + MODNAME,
            VERSION = "1.0.0";
        
        public static Harmony _harmony;
        
        public void Awake()
        {
            _harmony = new Harmony(GUID);
            _harmony.PatchAll(typeof(Patches.NoisemakerPatch));
        }
    }
}