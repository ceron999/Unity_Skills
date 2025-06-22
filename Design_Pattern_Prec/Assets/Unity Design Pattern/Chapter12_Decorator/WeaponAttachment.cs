using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Decorator
{
    [CreateAssetMenu(fileName = " NewWeaponAttachment",
                    menuName = "Weapon/Attatchment", order = 1)]
    public class WeaponAttachment : ScriptableObject, IWeapon
    {
        [Range(0, 50)]
        [Tooltip("Increase rate of firing per second")]
        [SerializeField]
        public float rate;

        [Range(0, 50)]
        [Tooltip("Increase Weapon Range")]
        [SerializeField]
        public float range;

        [Range(0, 100)]
        [Tooltip("Increase Weapon strength")]
        [SerializeField]
        public float strength;

        [Range(0, -5)]
        [Tooltip("Reduce cooldown duration")]
        [SerializeField]
        public float cooldown;

        public string attachmentName;
        public GameObject attachmentPrefab;
        public string attachmentDescription;

        public float Rate
        { get { return rate; } }
        public float Range
        { get { return range; } }
        public float Strength
        { get { return strength; } }
        public float Cooldown
        { get { return cooldown; } }
    }
}