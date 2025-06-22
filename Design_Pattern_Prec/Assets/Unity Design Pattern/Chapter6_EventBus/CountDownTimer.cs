using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.EventBus
{
    public class CountDownTimer : MonoBehaviour
    {
        private float _currentTIme;
        private float duration = 3.0f;

        private void OnEnable()
        {
            RaceEventBus.Subscribe(RaceEventType.COUNTDOWN, StartTimer);
        }

        private void OnDisable()
        {
            RaceEventBus.Unsubscribe(RaceEventType.COUNTDOWN, StartTimer);
        }

        private void StartTimer()
        {
            StartCoroutine(CountDown());
        }

        private IEnumerator CountDown()
        {
            _currentTIme = duration;

            while (_currentTIme > 0)
            {
                yield return new WaitForSeconds(1f);
                _currentTIme--;
            }

            RaceEventBus.Publish(RaceEventType.START);
        }

        private void OnGUI()
        {
            GUI.color = Color.red;

            GUI.Label(new Rect(125, 0, 100, 20), "Cuont Down: " + _currentTIme);
        }
    }
}