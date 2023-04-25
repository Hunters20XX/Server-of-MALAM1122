using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public TMP_Text levelText;
    public int levelCount = 1;
    public float timeInvertalA = 10;
    public float timeInvertalB = 30;


    void Start()
    {
        timerIsRunning = true;
        levelText.text = "Level " + levelCount.ToString();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            timeRemaining += Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        levelText.text = "Level " + levelCount.ToString();
    }

    void FixedUpdate()
    {
        if (timeRemaining > timeInvertalA)
        {
            levelCount += 1;
            timeInvertalA += 10;
        }
        if (timeRemaining > timeInvertalB)
        {
            GameObject.Find("Player").GetComponent<Health>().heart += 1;
            timeInvertalB += 30;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float hours = Mathf.FloorToInt(timeToDisplay / 24);
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time " + string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}
