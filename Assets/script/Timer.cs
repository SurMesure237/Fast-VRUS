using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Utilisez cet espace de noms pour Text Mesh Pro

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Référence au composant Text Mesh Pro UGUI
    private float startTime;
    private bool isTimerRunning = false;

    void Start()
    {
        StartTimer();
    }

    public void StartTimer()
    {
        startTime = Time.time;
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timerText.text = "time: " + minutes + ":" + seconds;
        }
    }

    public float GetCurrentTime()
    {
        return Time.time - startTime;
    }
}
