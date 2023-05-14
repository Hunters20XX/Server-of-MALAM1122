using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootC : MonoBehaviour
{
    public GameObject bulletPrefab;
    //Use the GameObject bullet, as a prefab and a weapon.

    List<GameObject> bulletPool = new List<GameObject>();
    //Speaking of weapon, have the list for the renewable bullets.

    public int bulletNum;
    //Have the amount of bullets used for the player.

    int bulletIndex = 0;
    //Have the bulletIndex to 0...whatever that suppose to mean.

    public float countDown = 6;

    public float choiceA = 0;
    public float choiceB = 0;

    DeltaTime clock;

    // Start is called before the first frame update
    void Start()
    {
        clock = GameObject.Find("Player").GetComponent<DeltaTime>();

        CreateBulletPool();
        //Made a void for CreateBulletPool().
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown < 0 && clock.levelCount > 160)
        {
            GameObject currentBullet = bulletPool[bulletIndex];
            //Use the GameObject currentBullet as the base for the bulletPool [and bulletIndex].

            currentBullet.SetActive(true);
            //Create a bullet based out of the amount of bulletPool.

            bulletIndex++;
            //Create a bulletIndex by 1.

            if (bulletIndex >= bulletPool.Count)
            {
                bulletIndex = 0;
            }
            //If the bulletIndex goes over the count of the bulletPool, then stay at 0.

            if (clock.levelCount > 160)
            {
                countDown = 3;

                currentBullet.transform.position = transform.position;
                //Have the bullet move forward based on the camera and the player's direction.

                currentBullet.GetComponent<ConstantForce>().force = new Vector3(choiceA * 2.6f, 0, choiceB * 2.6f);
            }

            if (clock.levelCount > 180)
            {
                countDown = 2;

                currentBullet.transform.position = transform.position;
                //Have the bullet move forward based on the camera and the player's direction.

                currentBullet.GetComponent<ConstantForce>().force = new Vector3(choiceA * 2.8f, 0, choiceB * 2.8f);
            }

            if (clock.levelCount >= 200)
            {
                countDown = 2;

                currentBullet.transform.position = transform.position;
                //Have the bullet move forward based on the camera and the player's direction.

                currentBullet.GetComponent<ConstantForce>().force = new Vector3(choiceA * 3, 0, choiceB * 3);
            }
        }
    }

    void CreateBulletPool()
    {
        for (int i = 0; i < bulletNum; i++)
        {
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            //Have the GameObject bullet appear in the direction the player is facing.

            newBullet.SetActive(false);
            //Disable the one already shot out, or something like that.

            bulletPool.Add(newBullet);
        }
        //Do the following task for the array list inside void CreateBulletPool().
    }
}
