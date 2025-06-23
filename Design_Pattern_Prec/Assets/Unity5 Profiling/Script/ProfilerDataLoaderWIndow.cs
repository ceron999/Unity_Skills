using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine.Profiling;

public class ProfilerDataLoaderWIndow : EditorWindow
{   
    static List<string> s_cachedFileDaths = new List<string>();
    static int s_cachedFileIndex = -1;

    [MenuItem("Window/ProfilerDataLoader")]
    static void Init()
    {
        ProfilerDataLoaderWIndow window =
            (ProfilerDataLoaderWIndow)EditorWindow.GetWindow(typeof(ProfilerDataLoaderWIndow));

        window.Show();

        ReadProfilerDataFiles();
    }

    static void ReadProfilerDataFiles()
    {
        string[] filePaths = Directory.GetFiles(Application.persistentDataPath, "profilerLog*");

        s_cachedFileDaths = new List<string>();

        Regex test = new Regex(".data$");

        for (int i = 0; i < filePaths.Length; i++)
        {
            string thisPath = filePaths[i];

            Match match = test.Match(thisPath);

            if(!match.Success)
            {
                Debug.Log("Found file : " +  thisPath);
                s_cachedFileDaths.Add(thisPath);
            }
        }

        s_cachedFileIndex = -1;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("find files"))
            ReadProfilerDataFiles();

        if (s_cachedFileDaths == null || s_cachedFileDaths.Count == 0)
            return;

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Files");

        GUIStyle defaultStyle = new GUIStyle(GUI.skin.button);
        defaultStyle.fixedWidth = 40f;
        GUIStyle highlightedStyle = new GUIStyle(defaultStyle);
        highlightedStyle.normal.textColor = Color.red;

        int buttonsPerRow = 5;

        for (int i = 0; i < s_cachedFileDaths.Count; i++)
        {
            if (i % buttonsPerRow == 0)
            {
                if (i != 0) EditorGUILayout.EndHorizontal(); // 이전 줄 닫기
                EditorGUILayout.BeginHorizontal();           // 새 줄 시작
            }

            GUIStyle thisStyle = (s_cachedFileIndex == i) ? highlightedStyle : defaultStyle;

            if (GUILayout.Button("" + i, thisStyle))
            {
                Profiler.AddFramesFromFile(s_cachedFileDaths[i]);
                s_cachedFileIndex = i;
            }
        }

        EditorGUILayout.EndHorizontal(); // 마지막 줄 닫기
    }
}
