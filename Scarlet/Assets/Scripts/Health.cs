using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int heart;
    public TMP_Text healthText;
    public GameObject theEnd;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + heart.ToString();
        theEnd.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + heart.ToString();
        if (heart <= 0)
        {
            GameObject.Find("vampire_neutral").GetComponent<Gameplay>().end = true;
            theEnd.SetActive(true);
            GameObject.Find("Game Manager").GetComponent<GameManager>().theMusic.Pause();
            heart = 0;
            Time.timeScale = 0;
        }
    }
}
