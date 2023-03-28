using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5;
    //The public int for the enemy's health is 5, needed to live.
    public GameObject block;
    //The block in the GameObject is needed in the enemy's keep.
    void Start()
    {
        block.gameObject.SetActive(false);
        //Have the block be invisible in the enemy's keep.
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
        //If the enemy lost all health, then it dies.


    }

    void OnTriggerEnter(Collider otherThing)
    {
        if (otherThing.gameObject.tag == "Bullet")
        {
            health--;
            otherThing.gameObject.SetActive(false);
        }
        //If the enemy takes a hit from an object tagged as "Bullet", then it loses a health by 1, and that bullet disappears.
    }

    void OnDisable()
    {
        block.gameObject.SetActive(true);
    }
    //When dead, the block object appears afterward.
}
