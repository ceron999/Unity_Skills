using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.State
{
    public interface IBikeState
    {
        public void Handle(BikeController bikeController);
    }
}