using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace PandaFeatBookMod
{
    [HarmonyPatch]
    internal class FeatBookPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TraitBookSecret), "OnRead")]
        static void Postfix(Chara c)
        {
            if (c.IsPC)
            {
                EClass.player.stats.kumi--;
            }
        }
    }
}
