using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Character.EventBus
{
    public class HUDController : MonoBehaviour
    {
        private bool _isDisplayOn;

        private void OnEnable()
        {
            RaceEventBus.Subscribe(RaceEventType.START, DIsplayHUD);
        }

        private void OnDisable()
        {
            RaceEventBus.Unsubscribe(RaceEventType.START, DIsplayHUD);
            
        }

        private void DIsplayHUD()
        {
            _isDisplayOn = true;
        }

        private void OnGUI()
        {
            if (_isDisplayOn)
            {
                if(GUILayout.Button("Stop Race"))
                {
                    _isDisplayOn = false;
                    RaceEventBus.Publish(RaceEventType.STOP);
                }

            }
        }
    }
}