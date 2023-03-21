using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            gameObject.SetActive(false);
            GameObject.Find("Key").GetComponent<ItemInfo>().gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider otherThing)
    {
        if (otherThing.gameObject.tag == "Bullet")
        {
            health--;           
        }
    }


}
