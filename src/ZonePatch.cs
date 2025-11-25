using HarmonyLib;
using UnityEngine;

namespace HighlightItem.src
{
    [HarmonyPatch(typeof(Zone))]
    [HarmonyPatch(nameof(Zone.Activate))]
    internal class ZonePatch
    {
        private static void Prefix()
        {
            Debug.Log("Harmoney Prefix");
        }

        private static void Postfix(Zone __instance)
        {
            Debug.Log("Harmoney Postfix");
            WidgetFeed.Instance?.Nerun(Lang.isJP ? "ここは" + __instance.Name + "ね！" : "This is " + __instance.Name + "!");
        }
    }
}