using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5;
    //The public int for the enemy's health is 5, needed to live.
    public GameObject block;
    //The block in the GameObject is needed in the enemy's keep.

    public AudioSource playeraudio;
    public AudioClip boop;
    public AudioClip dead;

    public float x;
    public float y;
    public float z;

    void Start()
    {
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
            playeraudio.PlayOneShot(boop);
        }
        //If the enemy takes a hit from an object tagged as "Bullet", then it loses a health by 1, and that bullet disappears.
    }

    void OnDisable()
    {
        block.transform.position = new Vector3 (x, y, z - 1.5f);

        playeraudio = GameObject.Find("Player").GetComponent<AudioSource>();
        playeraudio.PlayOneShot(dead);
    }
    //When dead, the block object appears afterward.
}
