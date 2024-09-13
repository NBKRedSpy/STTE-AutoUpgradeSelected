using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using RST;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AutoUpgradeSelectedCrew
{

    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static string ModAssemblyName => Assembly.GetExecutingAssembly().GetName().Name;

        public static ManualLogSource Log { get; set; }

        public static KeyCode UpgradeKey { get; private set; }

        private void Awake()
        {
            Log = Logger;

            UpgradeKey = Config.Bind("Options", nameof(UpgradeKey), KeyCode.LeftBracket,
                "The hotkey to upgraded the selected crewmembers").Value;

            Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
        }
    }
}
