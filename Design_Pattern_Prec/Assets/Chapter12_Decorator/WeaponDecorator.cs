using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Decorator
{
    public class WeaponDecorator : IWeapon
    {
        private readonly IWeapon _decoratedWeapon;
        private readonly WeaponAttachment _attatchment;

        public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
        {
            _attatchment = attachment;
            _decoratedWeapon = weapon;
        }

        public float Rate
        {
            get { return _decoratedWeapon.Rate + _attatchment.Rate; }
        }

        public float Range
        {
            get { return _decoratedWeapon.Range + _attatchment.Range; }
        }

        public float Strength
        {
            get { return _decoratedWeapon.Strength + _attatchment.Strength; }
        }

        public float Cooldown
        {
            get { return _decoratedWeapon.Cooldown + _attatchment.Cooldown; }
        }
    }
}