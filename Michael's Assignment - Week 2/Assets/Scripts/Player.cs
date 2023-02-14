using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    int health = 10;
    public TMP_Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(7, 0, 5);

        Vector3 currentPos = transform.position;

        if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow))
        {
            currentPos.x = currentPos.x + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            currentPos.x = currentPos.x - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            currentPos.z = currentPos.z + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            currentPos.z = currentPos.z - speed * Time.deltaTime;
        }
        transform.position = currentPos;
    }

    void OnCollisionEnter(Collision otherThing)
    {
        Debug.Log(otherThing.gameObject.name);
        if (otherThing.gameObject.name == "Enemy")
        {
            health--;
            healthText.text = "Health: " + health.ToString();
        }
    }
}
