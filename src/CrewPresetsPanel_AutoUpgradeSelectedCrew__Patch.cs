using HarmonyLib;
using RST.PlaymakerAction;
using RST;
using RST.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

namespace AutoUpgradeSelectedCrew
{

    /// <summary>
    /// Executes the crewmember auto upgrade for selected items.
    /// </summary>
    [HarmonyPatch(typeof(CrewPresetsPanel), nameof(CrewPresetsPanel.UpdatePresetVisibility))]
    public static class CrewPresetsPanel_AutoUpgradeSelectedCrew__Patch
    {
        public static void Postfix(CrewPresetsPanel __instance)
        {
            if (Input.GetKeyUp(Plugin.UpgradeKey))
            {
                List<Crewmember> upgradeableCrew = new List<Crewmember>();
                MultiSelection multiSelection = null;

                Crewmember crewmember = null;

                if (null != (crewmember = EventSystem.current?.currentSelectedGameObject?.GetComponent<Crewmember>()))
                {
                    if (crewmember.unusedSkillPoints > 0)
                    {
                        upgradeableCrew.Add(crewmember);
                    }
                }
                else if (null != (multiSelection = EventSystem.current?.currentSelectedGameObject?
                    .GetComponent<RST.MultiSelection>()))
                {
                    upgradeableCrew = multiSelection.selection
                        .Select(x => x.GetComponent<Crewmember>())
                        .Where(x => x != null && x.unusedSkillPoints > 0)
                        .ToList();
                }

                if (upgradeableCrew.Count > 0)
                {
                    foreach (Crewmember upgradeCrewMember in upgradeableCrew)
                    {
                        CrewAction.DoIt(CrewAction.Action.AutoLevelUp, upgradeCrewMember);
                    }
                }
            }
        }
    }

}
