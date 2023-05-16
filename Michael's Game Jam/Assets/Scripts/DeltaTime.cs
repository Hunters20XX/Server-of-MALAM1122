using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeltaTime : MonoBehaviour
{
    public float timeRemaining = 0;
    public TMP_Text timeText;
    public TMP_Text levelText;
    public GameObject impossibleText;
    public int levelCount = 0;
    public int levelRow = 0;

    public AudioSource playeraudio;
    public AudioClip pop;
    public AudioClip max;
    public AudioClip end;

    public bool finished = false;

    void Start()
    {
        levelText.text = "Level: " + levelCount.ToString();
        impossibleText.SetActive(false);
        InvokeRepeating("LevelUp", 10.0f, 10.0f);

    }

    void Update()
    {
        timeRemaining += Time.deltaTime;
        DisplayTime(timeRemaining);
        levelText.text = "Level: " + levelCount.ToString();

        if (timeRemaining >= 43200)
        {
            impossibleText.SetActive(true);
            timeRemaining = 0;
            Time.timeScale = 0;
            playeraudio.PlayOneShot(end);
            finished = true;
        }

        if (levelCount > 199)
        {
            levelText.text = "Level: MAX";
            CancelInvoke("LevelUp");
        }

        if (levelRow >= 10 && levelCount < 199)
        {
            levelRow = 0;
            playeraudio.PlayOneShot(pop);
        }
        if (levelRow >= 10 && levelCount > 199)
        {
            levelRow = 0;
            playeraudio.PlayOneShot(max);
        }
    }

    void LevelUp()
    {
        levelCount += 1;
        levelRow += 1;
    }

    void DisplayTime(float timeToDisplay)
    {
        float hours = Mathf.FloorToInt(timeToDisplay / 3600);
        float minutes = Mathf.FloorToInt(timeToDisplay / 60) % 60;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time: " + string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}
