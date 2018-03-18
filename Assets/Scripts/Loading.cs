using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider slider;
    AsyncOperation load;

	void Start()
	{
        load = SceneManager.LoadSceneAsync(2);
	}
	
	void Update()
	{
        slider.value = load.progress;
        if(load.isDone) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
