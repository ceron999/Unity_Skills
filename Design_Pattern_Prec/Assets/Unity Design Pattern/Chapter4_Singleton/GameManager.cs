using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Character.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        //private DateTime _sessonStartTime;
        //private DateTime _sessonEndTime;

        //private void Start()
        //{
        //    // TODO
        //    // - �÷��̾� ���̺� �ε�
        //    // - ���̺갡 ������ �÷��̾ ��� ������ �����̷��� �Ѵ�.
        //    // - �鿣�带 ȣ���ϰ� ���� ç������ ������ ��´�.

        //    _sessonStartTime = DateTime.Now;
        //    Debug.Log("Game Session start @: " + DateTime.Now);
        //}

        //private void OnApplicationQuit()
        //{
        //    _sessonEndTime = DateTime.Now;
        //    TimeSpan timeDifference = _sessonEndTime.Subtract(_sessonStartTime);

        //    Debug.Log("Game Session end @: " + DateTime.Now);
        //    Debug.Log("Game Session lasted : : " + timeDifference);
            
        //}

        //private void OnGUI()
        //{
        //    if(GUILayout.Button("Next Scene"))
        //    {
        //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //    }
        //}
    }
}