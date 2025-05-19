using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Facade
{
    public class BikeEngine : MonoBehaviour
    {
        public float fuelAmount = 100f;
        public float burnRate = 1f;
        public float currentTemp;
        public float minTemp = 50f;
        public float tempRate = 5f;
        public float maxTemp = 65f;
        public float turboDuration = 2f;


        private bool _isEngineOn;
        private FuelPump _fuelPump;
        private TurboCharger _turboCharger;
        private CoolingSystem _coolingSystem;

        // Start is called before the first frame update
        void Awake()
        {
            _fuelPump = gameObject.AddComponent<FuelPump>();
            _turboCharger = gameObject.AddComponent<TurboCharger>();
            _coolingSystem = gameObject.AddComponent<CoolingSystem>();

        }

        // Update is called once per frame
        void Start()
        {
            _fuelPump.engine = this;
            _turboCharger.engine = this;
            _coolingSystem.engine = this;
        }

        public void TurnOn()
        {
            _isEngineOn = true;

            StartCoroutine(_fuelPump.burnFuel);
            StartCoroutine(_coolingSystem.coolEngine);
        }

        public void TurnOff()
        {
            _isEngineOn = false;

            StopCoroutine(_fuelPump.burnFuel);
            StopCoroutine(_coolingSystem.coolEngine);
        }

        public void ToggleTurbo()
        {
            if (_isEngineOn)
                _turboCharger.ToggleTurbo(_coolingSystem);
        }

        private void OnGUI()
        {
            GUI.color = Color.green;
            GUI.Label(new Rect(100, 0, 500, 20), "Engine Running : " + _isEngineOn);
        }
    }
}