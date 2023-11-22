using System;
using System.Collections.Generic;
using System.Text;
using ModdingUtils.MonoBehaviours;
using UnityEngine;

namespace GambyCards.Monobehaviours
{
    internal class KnockbackEffect : ReversibleEffect
    {
        private int forceToAdd;
        public override void OnStart()
        {
            gun.AddAttackAction(OnShoot);
            forceToAdd = 10000;
        }

        private void OnShoot()
        {
            data.healthHandler.TakeForce(-data.hand.transform.forward * forceToAdd, ForceMode2D.Impulse, false, true, 0);
        }

        public override void OnOnDisable()
        {
            base.OnOnDisable();
        }

        public override void OnOnDestroy()
        {
            base.OnOnDestroy();
        }
    }
}
