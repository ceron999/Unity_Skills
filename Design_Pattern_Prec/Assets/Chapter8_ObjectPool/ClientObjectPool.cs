using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.ObjectPool
{
    public class ClientObjectPool : MonoBehaviour
    {
        private DroneObjectPool _pool;
        
        void Start()
        {
            _pool = gameObject.AddComponent<DroneObjectPool>();
        }
        private void OnGUI()
        {
            if (GUILayout.Button("Spawn Drone"))
                _pool.Spawn();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}