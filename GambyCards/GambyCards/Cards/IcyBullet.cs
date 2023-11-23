using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace GambyCards.Cards
{
    class IcyBullet : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.projectileSpeed = 1.75f;
            gun.reloadTimeAdd = 0.25f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override string GetTitle()
        {
            return "Frictionless Bullet";
        }

        protected override string GetDescription()
        {
            return "Bullets make your opponents slippery on hit.";
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
                    stat = "Bullet Speed",
                    amount = "+75%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },                           
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload Time",
                    amount = "0.25s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
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
