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
        }
        if (transform.position.x < -14 || transform.position.x > 14)
        {
            transform.position = new Vector3(0, 5, 0);
            heart -= 1;
        }
        healthText.text = "Health: " + heart.ToString();
    }
}
