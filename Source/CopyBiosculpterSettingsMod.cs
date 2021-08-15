using Verse;
using HarmonyLib;

namespace CopyBiosculpterSettings
{
    public class CopyBiosculpterSettingsMod : Mod
    {
        public const string PACKAGE_ID = "copybiosculptersettings.1trickPonyta";
        public const string PACKAGE_NAME = "Copy Biosculpter Settings";

        public CopyBiosculpterSettingsMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
