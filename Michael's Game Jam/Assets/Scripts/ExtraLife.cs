using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    public GameObject heart;
    List<GameObject> heartPool = new List<GameObject>();

    public int heartNum;
    int heartIndex = 0;

    public float countDown;

    public float zoneX;
    public float zoneZ;

    public AudioSource playeraudio;
    public AudioClip sprout;

    DeltaTime clock;
    // Start is called before the first frame update
    void Start()
    {
        clock = GameObject.Find("Player").GetComponent<DeltaTime>();

        CreateHeartPool();

    }

    // Update is called once per frame
    void Update()
    {
        if (clock.levelCount >= 20)
        {
            countDown -= Time.deltaTime;
        }

        zoneX = Random.Range(-8.5f, 8.5f);
        zoneZ = Random.Range(-8.5f, 8.5f);
        if (countDown <= 0)
        {
            playeraudio.PlayOneShot(sprout);

            GameObject currentHeart = heartPool[heartIndex];
            //Use the GameObject currentBullet as the base for the bulletPool [and bulletIndex].

            currentHeart.SetActive(true);
            //Create a bullet based out of the amount of bulletPool.

            heartIndex++;
            //Create a bulletIndex by 1.

            if (heartIndex >= heartPool.Count)
            {
                heartIndex = 0;
            }
            //If the bulletIndex goes over the count of the bulletPool, then stay at 0.


            if (clock.levelCount >= 20)
            {
                countDown = 30;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 40)
            {
                countDown = 27;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 60)
            {
                countDown = 24;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 80)
            {
                countDown = 21;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 100)
            {
                countDown = 18;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 120)
            {
                countDown = 15;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 140)
            {
                countDown = 12;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 160)
            {
                countDown = 9;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 180)
            {
                countDown = 6;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

            if (clock.levelCount >= 200)
            {
                countDown = 3;

                currentHeart.transform.position = new Vector3(zoneX, 20, zoneZ);
                //Have the bullet move forward based on the camera and the player's direction.
            }

        }
    }

    void CreateHeartPool()
    {
        for (int i = 0; i < heartNum; i++)
        {
            GameObject newHeart = Instantiate(heart, transform.position, Quaternion.identity);
            //Have the GameObject bullet appear in the direction the player is facing.

            newHeart.SetActive(false);
            //Disable the one already shot out, or something like that.

            heartPool.Add(newHeart);
        }
        //Do the following task for the array list inside void CreateBulletPool().
    }
}
