using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.EventBus
{
    public class BikeController : MonoBehaviour
    {
        private string _status;

        private void OnEnable()
        {
            RaceEventBus.Subscribe(RaceEventType.START, StartBike);
            RaceEventBus.Subscribe(RaceEventType.STOP, StopBike);
        }

        private void OnDisable()
        {
            RaceEventBus.Unsubscribe(RaceEventType.START, StartBike);
            RaceEventBus.Unsubscribe(RaceEventType.STOP, StopBike);
        }

        private void StartBike()
        {
            _status = "started";
        }

        private void StopBike()
        {
            _status = "Stoped";
        }

        private void OnGUI()
        {
            GUI.color = Color.red;

            GUI.Label(new Rect(10, 60, 200, 20), "Bike Status : " +  _status);
        }
    }
}