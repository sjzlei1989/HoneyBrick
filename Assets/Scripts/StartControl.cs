using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControl : MonoBehaviour
{
    public GameObject win;
    public GameObject android;

    // Use this for initialization
    void Start() {
#if UNITY_EDITOR || UNITY_WIN
        win.SetActive(true);
#elif UNITY_ANDROID
        android.SetActive(true);
#endif
    }
}
