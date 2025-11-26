using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using CsvHelper;
using HarmonyLib;
using UnityEngine;

namespace HighlightItem
{
    [HarmonyPatch(typeof(Map), nameof(Map.OnCardAddedToZone))]
    internal class OnDropItemPatch
    {
        private static void Postfix(Map __instance, Card t)
        {
            Debug.Log("OnCardAddedToZone called");

            // 変数tがThing型にキャストできない場合、またはそのplaceStateがroamingでない場合は処理を終了する
            if (t is not Thing thing || thing.placeState is not PlaceState.roaming)
                return;

            Debug.Log("this item is thing and placeState is roaming");


            // Plugin.LogInfo(p);
            // Plugin.LogInfo(t);
            // if (Plugin.UserFilterList.Count == 0)
            //     return;
            //
            // var itemEnchantName = __0.Card.Name.StartsWith("☆") ? __0.Card.Name : instance.Name;
            // Debug.Log(itemEnchantName);
            //
            // Plugin.UserFilterList.ForEach(userFilter =>
            // {
            //     if (!string.IsNullOrEmpty(userFilter.EnchantName))
            //         return;
            //
            //     if (itemEnchantName.Contains(userFilter.EnchantName!))
            //         __0.Attach("guide", false);
            // });
        }
    }
}

