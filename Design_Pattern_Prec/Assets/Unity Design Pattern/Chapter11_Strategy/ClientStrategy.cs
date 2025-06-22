using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Chapter.Strategy
{
    internal class ClientStrategy: MonoBehaviour
    {
        private GameObject _drone;
        private List<IManeuverBehavior> _components = new List<IManeuverBehavior>();

        private void SpawnDrone()
        {
            _drone = GameObject.CreatePrimitive(PrimitiveType.Cube);

            _drone.AddComponent<Drone>();

            _drone.transform.position = UnityEngine.Random.insideUnitSphere * 10f;

            ApplyRandomStrategies();
        }

        private void ApplyRandomStrategies()
        {
            _components.Add(_drone.AddComponent<WeavingManeuver>());
            _components.Add(_drone.AddComponent<BoppingManeuver>());
            _components.Add(_drone.AddComponent<FallbackManeuver>());

            int index = UnityEngine.Random.Range(0, _components.Count);

            _drone.GetComponent<Drone>().ApplyStrategy(_components[index]); 
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Spawn Drone"))
                SpawnDrone();
        }
    }
}
