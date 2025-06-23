using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class ProfilerDataSaverComponent : MonoBehaviour
{
    int m_count = 0;

    private void Start()
    {
        Profiler.logFile = "";


        string filepath = Application.persistentDataPath + "/profilerLog" + m_count;
        Debug.Log(filepath);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log(1);
            StopAllCoroutines();
            m_count = 0;
            StartCoroutine(SaveProfileData());
        }
    }

    IEnumerator SaveProfileData()
    {
        while (true)
        {
            string filepath = Application.persistentDataPath + "/profilerLog" + m_count + ".data";

            Profiler.logFile = filepath;
            Profiler.enableBinaryLog = true;
            Profiler.enabled = true;

            Debug.Log("Profiling to: " + filepath);

            // 수집 시간 확보
            for (int i = 0; i < 300; ++i)
            {
                yield return new WaitForEndOfFrame();
            }

            Profiler.enabled = false; // 저장
            Profiler.enableBinaryLog = false;

            Debug.Log("Saved: " + filepath);
            m_count++;
        }
    }
}
