using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.State
{
    public class BikeTurnState : MonoBehaviour, IBikeState
    {
        private Vector3 _turnDIrection;
        private BikeController _bikeController;

        public void Handle(BikeController bikeController)
        {
            if(!_bikeController)
                _bikeController = bikeController;

            _turnDIrection.x = (float)_bikeController.CurrentTurnDirection;

            if(_bikeController.CurrentSpeed > 0)
            {
                transform.Translate(_turnDIrection * _bikeController.turnDistance);
            }

        }
    }
}