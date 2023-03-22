using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5;
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        block.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }


    }

    void OnTriggerEnter(Collider otherThing)
    {
        if (otherThing.gameObject.tag == "Bullet")
        {
            health--;
            otherThing.gameObject.SetActive(false);
        }
    }

    void OnDisable()
    {
        block.gameObject.SetActive(true);
    }
}
