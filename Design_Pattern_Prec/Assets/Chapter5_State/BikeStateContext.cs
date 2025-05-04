using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.State
{
    public class BikeStateContext
    {
        public IBikeState CurrState
        {
            get;
            set;
        }

        private readonly BikeController _bikeController;

        public BikeStateContext(BikeController bikeController)
        {
            _bikeController = bikeController;
        }

        public void Transition()
        {
            CurrState.Handle(_bikeController);
        }

        public void Transition(IBikeState state)
        {
            CurrState = state;
            CurrState.Handle(_bikeController);
        }
    }
}
