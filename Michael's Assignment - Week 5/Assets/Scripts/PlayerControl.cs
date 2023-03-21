using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;

    private float movementX;
    private float movementY;

    int sphere = 0;
    int health = 5;
    public TMP_Text sphereText;
    public TMP_Text healthText;
    public GameObject winText;
    public GameObject endText;


    // Start is called before the first frame update
    void Start()
    {
        sphereText.text = "Sphere: " + sphere.ToString() + " / 90";
        healthText.text = "Health: " + health.ToString();
        winText.SetActive(false);
        endText.SetActive(false);

        rb = GetComponent<Rigidbody>();

    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere == 90)
        {
            winText.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "PickUp")
        {
            sphere++;
            sphereText.text = "Sphere: " + sphere.ToString() + " / 90";
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Bullet")
        {
            health--;
            healthText.text = "Health: " + health.ToString();
            other.gameObject.SetActive(false);
            if (health <= 0)
            {
                endText.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
