using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryDisable : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                canBePressed = false;
                
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Attacker")
        {
            canBePressed = true;
        }
    }

    void OnEnable()
    {
        CancelInvoke("Respawn");
    }

    void OnDisable()
    {
        InvokeRepeating("Respawn", 5.0f, 5.0f);
    }

    void Respawn()
    {
        gameObject.SetActive(true);
    }
}
