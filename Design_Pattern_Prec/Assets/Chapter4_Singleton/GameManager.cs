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
        //    // - 플레이어 세이브 로드
        //    // - 세이브가 없으면 플레이어를 등록 씬으로 리다이렉션 한다.
        //    // - 백엔드를 호출하고 일일 챌린지와 보상을 얻는다.

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