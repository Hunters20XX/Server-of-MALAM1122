using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int heart = 5;
    public TMP_Text healthText;
    public GameObject endText;
    public bool protection = false;
    public float Shield = 3;
    public GameObject protectText;
    public TMP_Text shieldText;
    public GameObject Player;

    public AudioSource playeraudio;
    public AudioClip hit;
    public AudioClip ouch;
    public AudioClip dead;
    public AudioClip extra;


    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + heart.ToString();
        endText.SetActive(false);
        protectText.SetActive(false);
        Player.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (heart <= 0)
        {
            Player.SetActive(false);
            endText.SetActive(true);
            Time.timeScale = 0;
        }

        if (heart >= 50)
        {
            heart = 50;
        }

        if (protection == true)
        {
            Shield -= Time.deltaTime;
            GetComponent<Renderer>().material.color = new Color(218, 0, 255);
            protectText.SetActive(true);
            DisplayTime(Shield);
            if (Shield < 1)
            {
                protection = false;
                Shield = 4;
                protectText.SetActive(false);
                GameObject.Find("Player").GetComponent<Renderer>().material.color = new Color(255, 254, 0);
            }
        }

        healthText.text = "Health: " + heart.ToString();
    }

    void FixedUpdate()
    {
        if (transform.position.y < -15 && protection == false)
        {
            transform.position = new Vector3(0, 5, 0);
            heart -= 1;
            protection = true;
            if (heart > 0)
            {
                playeraudio.PlayOneShot(ouch);
            }
        }
        if (transform.position.z < -14 && protection == false || transform.position.z > 14 && protection == false)
        {
            transform.position = new Vector3(0, 5, 0);
            heart -= 1;
            protection = true;
            if (heart > 0)
            {
                playeraudio.PlayOneShot(ouch);
            }
        }
        if (transform.position.x < -14 && protection == false || transform.position.x > 14 && protection == false)
        {
            transform.position = new Vector3(0, 5, 0);
            heart -= 1;
            protection = true;
            if (heart > 0)
            {
                playeraudio.PlayOneShot(ouch);
            }
        }

        if (transform.position.y < -15 && protection == true)
        {
            transform.position = new Vector3(0, 5, 0);
        }
        if (transform.position.z < -14 && protection == true || transform.position.z > 14 && protection == true)
        {
            transform.position = new Vector3(0, 5, 0);
        }
        if (transform.position.x < -14 && protection == true || transform.position.x > 14 && protection == true)
        {
            transform.position = new Vector3(0, 5, 0);
        }
        healthText.text = "Health: " + heart.ToString();
    }

    void OnTriggerEnter(Collider otherThing)
    {
        if (otherThing.gameObject.tag == "Bullet" && protection == false && heart > 0)
        {
            heart--;
            otherThing.gameObject.SetActive(false);
            protection = true;
            playeraudio.PlayOneShot(hit);
            if (heart > 0)
            {
                playeraudio.PlayOneShot(ouch);
            }
        }
        //If the enemy takes a hit from an object tagged as "Bullet", then it loses a health by 1, and that bullet disappears.

        if (otherThing.gameObject.tag == "Laser" && protection == false && heart > 0)
        {
            heart--;
            protection = true;
            playeraudio.PlayOneShot(hit);
            if (heart > 0)
            {
                playeraudio.PlayOneShot(ouch);
            }
        }

        if (otherThing.gameObject.tag == "1up")
        {
            heart++;
            otherThing.gameObject.SetActive(false);

            playeraudio.PlayOneShot(extra);
            if (protection == false)
            {
                protection = true;
            } else if (protection == true)
            {
                Shield = 4;
            }
            
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(timeToDisplay);
        shieldText.text = "Shield: " + string.Format("{0}", seconds);
    }

    void OnDisable()
    {
        playeraudio.PlayOneShot(dead);
    }
}
