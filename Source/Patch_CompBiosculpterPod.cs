using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace CopyBiosculpterSettings
{
    [HarmonyPatch(typeof(CompBiosculpterPod))]
    [HarmonyPatch("CompGetGizmosExtra")]
    public static class Patch_CompBiosculpterPod_CompGetGizmosExtra
    {
        public static void Postfix(CompBiosculpterPod __instance, ref IEnumerable<Gizmo> __result)
        {
            StorageSettings storeSettings = __instance.GetStoreSettings();
            foreach (Gizmo gizmo in StorageSettingsClipboard.CopyPasteGizmosFor(storeSettings))
            {
                __result = __result.Concat(gizmo);
            }
        }
    }
}
