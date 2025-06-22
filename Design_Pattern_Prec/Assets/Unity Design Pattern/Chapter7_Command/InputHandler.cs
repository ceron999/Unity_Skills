using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.Command
{
    public class InputHandler : MonoBehaviour
    {
        private Invoker _invoker;
        private bool _isReplaying;
        private bool _isRecording;
        private BikeController _bikeController;
        private Command _buttonA, _buttonD, _buttonW;

        private void Start()
        {
            _invoker = gameObject.AddComponent<Invoker>();
            _bikeController = FindObjectOfType<BikeController>();
            _buttonA = new TurnLeft(_bikeController);
            _buttonD = new TurnRight(_bikeController);
            _buttonW = new ToggleTurbo(_bikeController);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                _invoker.ExecuteCommand(_buttonA);

            if (Input.GetKeyDown(KeyCode.D))
                _invoker.ExecuteCommand(_buttonD);

            if (Input.GetKeyDown(KeyCode.W))
                _invoker.ExecuteCommand(_buttonW);
        }

        private void OnGUI()
        {
            if(GUILayout.Button("Start Recording"))
            {
                _bikeController.ResetPosition();
                _isReplaying = false;
                _isRecording = true;
                _invoker.Record();
            }

            if (GUILayout.Button("Stop Recording"))
            {
                _bikeController.ResetPosition();
                _isRecording = false;
                _invoker.StopRecord();
            }
            if (!_isRecording)
            {
                if (GUILayout.Button("Start Replaying"))
                {
                    _bikeController.ResetPosition();
                    _isRecording = false;
                    _isReplaying = true;
                    _invoker.Replay();
                }
            }
        }
    }
}