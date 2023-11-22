using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using GambyCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace GambyCards
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin(ModId, ModName, Version)]

    [BepInProcess("Rounds.exe")]
    public class GambyCards : BaseUnityPlugin
    {
        private const string ModId = "com.gambyte.rounds.GambyCards";
        private const string ModName = "GambyCards";
        private const string Version = "0.1.1";

        public const string ModInitials = "GC";
        public static GambyCards instance { get; set; }

        void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        void Start()
        {
            instance = this;
            CustomCard.BuildCard<EvasiveManeuvers>();
            //CustomCard.BuildCard<CrazyBullets>();
            CustomCard.BuildCard<ChonkyBullets>();
            CustomCard.BuildCard<TanksBane>();
            CustomCard.BuildCard<HeliumBullets>();
            //CustomCard.BuildCard<BouncyBombs>();
            CustomCard.BuildCard<Blunderbuss>();
            //CustomCard.BuildCard<RunnyBullets>();
        }
    }
}
