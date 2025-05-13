using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Chapter.Decorator
{
    public class Weapon : MonoBehaviour, IWeapon
    {
        public float Range
        {
            get { return _config.Range; }
        }

        public float Rate
        {
            get { return _config.Rate; }
        }
        public float Strength
        {
            get { return _config.Strength; }
        }

        public float Cooldown
        {
            get { return _config.Cooldown; }
        }

        private readonly WeaponConfig _config;

        public Weapon(WeaponConfig weaponConfig)
        {
            _config = weaponConfig;
        }
    }
}