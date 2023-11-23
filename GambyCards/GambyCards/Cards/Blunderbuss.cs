using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using GambyCards.Monobehaviours;

namespace GambyCards.Cards
{
    class Blunderbuss : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.numberOfProjectiles = 10;
            gun.damage = 0.5f;
            gun.spread = 0.5f;
            gun.reloadTimeAdd = 0.5f;
            gun.destroyBulletAfter = 0.3f;
            gun.gravity = 0;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            KnockbackEffect orAddComponent = ExtensionMethods.GetOrAddComponent<KnockbackEffect>(player.gameObject);
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            KnockbackEffect orAddComponent = ExtensionMethods.GetOrAddComponent<KnockbackEffect>(player.gameObject);
            UnityEngine.Object.Destroy(orAddComponent);
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override string GetTitle()
        {
            return "Blunderbuss";
        }

        protected override string GetDescription()
        {
            return "Yarr, matey yar gun be looking mighty bussin.";
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Projectiles",
                    amount = "+10",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Damage",
                    amount = "-50%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload Time",
                    amount = "+0.5s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
            };

        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.EvilPurple;
        }

        public override string GetModName()
        {
            return GambyCards.ModInitials;
        }
    }
}
