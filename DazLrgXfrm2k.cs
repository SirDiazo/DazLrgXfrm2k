using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMod;
using HarmonyLib;
using UnityEngine;


namespace DazLrgXfrm2k
{
    public class DazPatches : UserMod2 //mod loading class
    {
        [HarmonyPatch(typeof(PowerTransformerConfig), "CreateBuildingDef")]
        public static class DazPwrXfrmLrg2kPatch
        {
            internal static void Postfix(ref BuildingDef __result)
            {
                Debug.Log("Daz xfomre 2k");
                __result.GeneratorWattageRating = 2000f;
                __result.GeneratorBaseCapacity = 2000f;
            }
        }
    }
}
