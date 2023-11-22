using System;
using System.Collections.Generic;
using System.Text;
using ModdingUtils.RoundsEffects;
using UnityEngine;

namespace GambyCards.Monobehaviours
{
    internal class SpeedBounceEffect : HitSurfaceEffect
    {
        public Player player;

        public CharacterStatModifiers characterStatModifiers;

        public int numberOfObjects = 0;

        private float orignalSpeed;

        public void Start()
        {
            player = GetComponentInParent<ProjectileHit>().ownPlayer;
            characterStatModifiers = player.GetComponentInParent<CharacterStatModifiers>();
            orignalSpeed = characterStatModifiers.movementSpeed;
        }

        public void Awake()
        {
        }

        public void OnDestroy()
        {
            characterStatModifiers.movementSpeed = orignalSpeed;
        }

        public override void Hit(Vector2 position, Vector2 normal, Vector2 velocity)
        {
            characterStatModifiers.movementSpeed += 100;
        }
    }
}
