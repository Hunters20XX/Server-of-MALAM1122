using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class Gameplay : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public GameObject results;
    public GameObject pauseText;
    public TMP_Text hitsText;
    public TMP_Text scoreText;
    /*
    public TMP_Text rankhitText;
    public TMP_Text rankscoreText;
    */
    public int hits;
    public int score;
    public int totalNotes;
    public int totalScore;
    /*
    public bool rankD1;
    public bool rankC1;
    public bool rankB1;
    public bool rankA1;
    public bool rankS1;
    public bool rankD2;
    public bool rankC2;
    public bool rankB2;
    public bool rankA2;
    public bool rankS2;
    */

    public bool pause = false;
    public bool end = false;
    public static float unscaledTime;


    void Start()
    {

        timerIsRunning = true;
        hitsText.text = "Total Hits: " + hits.ToString() + " / " + totalNotes + " = ";
        scoreText.text = "Total Score: " + score.ToString() + " / " + totalScore + " = ";
        results.SetActive(false);

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
                results.SetActive(true);
                end = true;
                timerIsRunning = false;
                Time.timeScale = 0;
                hitsText.text = "Total Hits: " + hits.ToString() + " / " + totalNotes;
                scoreText.text = "Total Score: " + score.ToString();

                /*
                if (rankD1 == false)
                {
                    rankhitText.text = "Fail";
                }
                if (rankD2 == false)
                {
                    rankscoreText.text = "Fail";
                }
                if (rankD1 == true)
                {
                    rankhitText.text = "D";
                }
                if (rankD2 == true)
                {
                    rankscoreText.text = "D";
                }
                if (rankC1 == true)
                {
                    rankhitText.text = "C";
                }
                if (rankC2 == true)
                {
                    rankscoreText.text = "C";
                }
                if (rankB1 == true)
                {
                    rankhitText.text = "B";
                }
                if (rankB2 == true)
                {
                    rankscoreText.text = "B";
                }
                if (rankA1 == true)
                {
                    rankhitText.text = "A";
                }
                if (rankA2 == true)
                {
                    rankscoreText.text = "A";

                }
                if (rankS1 == true)
                {
                    rankhitText.text = "S";
                }
                if (rankS2 == true)
                {
                    rankscoreText.text = "S";
                }*/
            }          
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            pause = !pause;

            //more code here
        }
        if (pause == true && end == false)
        {
            Time.timeScale = 0;
            pauseText.SetActive(true);
        }
        else if (pause == false && end == false)
        {
            Time.timeScale = 1;
            pauseText.SetActive(false);
        }
        /*
        if (hits > totalNotes * 0.2)
        {
            rankD1 = true;
        }
        if (hits > totalNotes * 0.4)
        {
            rankC1 = true;
            rankD1 = false;
        }
        if (hits > totalNotes * 0.6)
        {
            rankB1 = true;
            rankC1 = false;
        }
        if (hits > totalNotes * 0.8)
        {
            rankA1 = true;
            rankB1 = false;
        }
        if (hits >= totalNotes)
        {
            rankS1 = true;
            rankA1 = false;
        }
        if (score > totalScore * 0.2)
        {
            rankD2 = true;
        }
        if (score > totalScore * 0.4)
        {
            rankC2 = true;
            rankD2 = false;
        }
        if (score > totalScore * 0.6)
        {
            rankB2 = true;
            rankC2 = false;
        }
        if (score > totalScore * 0.8)
        {
            rankA2 = true;
            rankB2 = false;
        }
        if (score >= totalScore)
        {
            rankS2 = true;
            rankA2 = false;
        }*/
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}