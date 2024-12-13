using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;

namespace PandaFeatBookMod
{
    [BepInPlugin("panda.featbook.mod", "Panda's Feat Book Mod", "1.0.0.0")]
    internal class Mod_PandaFeatBookMod : BaseUnityPlugin
    {
        private void Start()
        {
            var harmony = new Harmony("Panda's Feat Book Mod");
            harmony.PatchAll();
        }
    }
}
