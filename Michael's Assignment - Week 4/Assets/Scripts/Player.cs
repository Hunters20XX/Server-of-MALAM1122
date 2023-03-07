using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    int sphere = 0;
    public TMP_Text sphereText;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").GetComponent<Timer>();
        sphereText.text = "Sphere: " + sphere.ToString() + " / 20";
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
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

        if (sphere == 20)
        {
            GameObject.Find("Player").GetComponent<Timer>().timerIsRunning = false;
            winText.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnCollisionEnter(Collision otherThing)
    {
        Debug.Log(otherThing.gameObject.name);
        if (otherThing.gameObject.tag == "PickUp")
        {
            sphere++;
            sphereText.text = "Sphere: " + sphere.ToString() + " / 20";
            Destroy(otherThing.gameObject);
        }
    }
}
