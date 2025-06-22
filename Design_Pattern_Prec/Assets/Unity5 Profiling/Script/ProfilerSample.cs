using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class ProfilerSample : MonoBehaviour
{
    
    void Update()
    {
        DoSomethingCompletelyStupid();
    }

    void DoSomethingCompletelyStupid()
    {
        Profiler.BeginSample("My profiler sample");
        
        List<int> listOfInt = new List<int>();
        for(int i =0; i<1000000;++i)
        { 
            listOfInt.Add(i);
        }

        Profiler.EndSample();
    }
}
