using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Observer
{
    public class Subject : MonoBehaviour
    {
        private readonly ArrayList _observers = new ArrayList();


        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (Observer observer in _observers)
            {
                observer.Notify(this);
            }
        }
    }
}