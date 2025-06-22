using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CustomTimer : MonoBehaviour, IDisposable
{
    private string m_timerName;
    private int m_numTests;
    private Stopwatch m_watch;


    private void Start()
    {
        int numtest = 1000;

        using (new CustomTimer("My Test", numtest))
        {
            for(int i =0; i<numtest;++i)
            {
                TestFunction();
            }
        }
    }

    public CustomTimer(string timerName, int numTests)
    {
        m_timerName = timerName;
        m_numTests = numTests;

        if (m_numTests <= 0)
            m_numTests = 1;
        m_watch = Stopwatch.StartNew();
    }   

    public void Dispose()
    {
        m_watch.Stop();
        float ms = m_watch.ElapsedMilliseconds;
        UnityEngine.Debug.Log(string.Format("{0} finished : {1:0.00}ms total {2:0.000000}ms per test for {3} tests"
            , m_timerName, ms, ms / m_numTests, m_numTests));
    }

    private void TestFunction()
    {
        // �׽�Ʈ�� �Լ� ����
        UnityEngine.Debug.Log("TestFunction called.");
    }
}
