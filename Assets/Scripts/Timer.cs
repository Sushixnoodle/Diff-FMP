using System.Collections;
using System.Collections.Generic;
//using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public string LevelToLoad;
    public float timer;
    private Text timerSeconds;
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            Application.LoadLevel(LevelToLoad);
        }

    }
}
