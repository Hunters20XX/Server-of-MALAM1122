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
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + heart.ToString();
        endText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (heart <= 0)
        {
            endText.SetActive(true);
            Time.timeScale = 0;
        }

        if (heart >= 9)
        {
            heart = 9;
        }

        if (protection == true)
        {
            Shield -= Time.deltaTime;
            GameObject.Find("Player").GetComponent<Renderer>().material.color = new Color(218, 0, 255);
            if (Shield < 0)
            {
                protection = false;
                Shield = 3;
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
        }
        if (transform.position.z < -14 && protection == false || transform.position.z > 14 && protection == false)
        {
            transform.position = new Vector3(0, 5, 0);
            heart -= 1;
            protection = true;
        }
        if (transform.position.x < -14 && protection == false || transform.position.x > 14 && protection == false)
        {
            transform.position = new Vector3(0, 5, 0);
            heart -= 1;
            protection = true;
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
        if (otherThing.gameObject.tag == "Bullet" && protection == false)
        {
            heart--;
            otherThing.gameObject.SetActive(false);
            protection = true;
        }
        //If the enemy takes a hit from an object tagged as "Bullet", then it loses a health by 1, and that bullet disappears.
    }
}
