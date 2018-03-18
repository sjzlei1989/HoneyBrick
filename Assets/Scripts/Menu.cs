using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject win;
    public GameObject android;
    public bool isStart = false;
    public GameObject quitHint;

    /// <summary>
    /// 双击退出键退出游戏时间间隔
    /// </summary>
    public float doubleClickQuitInterval = 0.5f;
    float doubleClickTimer = 0;
    // Use this for initialization
    void Start() {
#if UNITY_EDITOR || UNITY_WIN
        win.SetActive(true);
#elif UNITY_ANDROID
        android.SetActive(true);
#endif
    }

    private void Update() {
        if(doubleClickTimer > 0) {
            doubleClickTimer -= Time.deltaTime;
            if(doubleClickTimer <= 0) {
                doubleClickTimer = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(doubleClickTimer > 0) {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.ExecuteMenuItem("Edit/Play");
#else
                Application.Quit();
#endif
            }
            else {
                quitHint.SetActive(true);
                doubleClickTimer = doubleClickQuitInterval;
            }
        }
    }

    public void StartGame() {
        if(isStart == false) {
            isStart = true;
            SceneManager.LoadScene(1);
        }
    }
}
