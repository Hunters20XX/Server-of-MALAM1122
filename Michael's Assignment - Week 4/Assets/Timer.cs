using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public GameObject endText;
    public TMP_Text timeText;


    void Start()
    {
        timerIsRunning = true;
        endText.SetActive (false);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 1)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else if (timeRemaining <= 1)
            {
                endText.SetActive(true);
                timerIsRunning = false;
                Time.timeScale = 0;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}