using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.ServiceLocator
{
    public class ClientServiceLocator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            RegisterServices();
        }
        private void RegisterServices()
        {
            ILoggerService logger = new Logger();
            ServiceLocator.RegisterService(logger);


            IAnalyticsService analytics = new Analytics();
            ServiceLocator.RegisterService(analytics);

            IAdvertisement ad = new Advertisement();
            ServiceLocator.RegisterService(ad);
        }

        private void OnGUI()
        {
            GUILayout.Label("Review output in the console");

            if(GUILayout.Button("Log Event"))
            {
                ILoggerService logger = ServiceLocator.GetService<ILoggerService>();
                logger.Log("Hello world");
            }

            if (GUILayout.Button("Send Analytics"))
            {
                IAnalyticsService analytics = ServiceLocator.GetService<IAnalyticsService>();
                analytics.SendEvent("Hello worlf");
            }

            if (GUILayout.Button("Log Event"))
            {
                IAdvertisement ad = ServiceLocator.GetService<IAdvertisement>();
                ad.DIsplayAd();
            }
        }
    }
}