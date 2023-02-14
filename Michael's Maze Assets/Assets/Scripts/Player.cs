using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public GameObject winTextObject;
    public float threshold;

    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody>();
    winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (kb.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("SampleScene");
        }

        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

        if (transform.position.y < threshold)
        {
            winTextObject.SetActive(true);
        }
    }
}
