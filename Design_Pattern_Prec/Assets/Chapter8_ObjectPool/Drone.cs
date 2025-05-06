using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace Character.ObjectPool
{

    public class Drone : MonoBehaviour
    {
        public IObjectPool<Drone> Pool { get; set; }

        public float _currentHeath;

        [SerializeField]
        private float maxHeath = 100.0f;

        // Start is called before the first frame update
        void Start()
        {
            _currentHeath = maxHeath;
        }

        private void OnEnable()
        {
            AttackPlayer();
            StartCoroutine(SelfDestruct());
        }
        private void OnDisable()
        {
            ResetDrone();
        }

        private IEnumerator SelfDestruct()
        {
            yield return new WaitForSeconds(1);
            TakeDamage(1);
        }
        private void ReturnToPool()
        {
            Pool.Release(this);
        }
        private void AttackPlayer()
        {
            Debug.Log("Attack Player");
        }

       
        private void ResetDrone()
        {
            _currentHeath = maxHeath;
        }


        private void TakeDamage(float amount)
        {
            _currentHeath -= amount;
            if (_currentHeath <= 0)
                ReturnToPool();
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}