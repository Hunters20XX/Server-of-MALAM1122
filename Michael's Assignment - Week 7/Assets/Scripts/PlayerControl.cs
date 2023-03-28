using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        characterControl = GetComponent<CharacterController>();
        //Have the characterControl get the component of CharacterController inside the object.

        itemText.text = lookingAt;
        //Have the itemText.text be display with lookingAt.

        Cursor.lockState = CursorLockMode.Locked;
        //Lock the cursor in a mode, or whatever, more on that later.

        CreateBulletPool();
        //Made a void for CreateBulletPool().
    }
    //Do the following task in the void Start().

    public float speed;
    //Use and adjust the speed when possible.

    public float upRotation;
    //Rotate upwards, on a restricted number to stop.

    public float downRotation;
    //Rotate downwards, on a restricted number to stop.

    public TMP_Text itemText;
    //Display the itemText in the canvas.

    public string lookingAt = "Nothing";
    //Have the string of lookingAt as "Nothing."

    CharacterController characterControl;
    //Use the CharacterController for characterControl.

    public Transform playerCam;
    //Using the transfromation for the playerCam.

    public bool hasAllKeys = false;
    //Have the boolean of hasAllKeys as false, since the player didn't get all the keys yet.

    Vector3 vel;
    //Have the vector3 be use for velocity.

    public float lookSensitivity;
    //Have the float for the sensitivity of how fast we look around.

    float xRotation = 0;
    //Rotate left or right as 0.

    public GameObject bulletPrefab;
    //Use the GameObject bullet, as a prefab and a weapon.

    List<GameObject> bulletPool = new List<GameObject>();
    //Speaking of weapon, have the list for the renewable bullets.

    public int bulletNum;
    //Have the amount of bullets used for the player.

    int bulletIndex = 0;
    //Have the bulletIndex to 0...whatever that suppose to mean.

    public AudioSource playeraudio;
    public AudioClip shoot;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject currentBullet = bulletPool[bulletIndex];
            //Use the GameObject currentBullet as the base for the bulletPool [and bulletIndex].

            currentBullet.SetActive(true);
            //Create a bullet based out of the amount of bulletPool.

            currentBullet.transform.position = transform.position;
            //Have the bullet move forward based on the camera and the player's direction.

            currentBullet.GetComponent<Rigidbody>().velocity = 5 * transform.forward;
            //Have the bullet move forward with the Rigidbody and the velocity based on transform.forward and a number.

            bulletIndex++;
            //Create a bulletIndex by 1.

            if (bulletIndex >= bulletPool.Count)
            {
                bulletIndex = 0;
            }
            //If the bulletIndex goes over the count of the bulletPool, then stay at 0.

            playeraudio.PlayOneShot(shoot);
        }
        //Do the following task if the mouse is left-clicked, once each time.

        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
            //Have the camera look around with "Mouse X" based on the lookSensitivity.

            xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
            //Have the camera look horizontally with "Mouse Y" based on the lookSensitivity.

            xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
            //Have the camera look horizontally with itself, -upRotation, and downRotation.

            playerCam.localRotation = Quaternion.Euler(xRotation, 0, 0);
            //Use the camera as a playerCam for the xRotation.
        }
        //Do the following if the mouse is right-clicked and hold.

        vel.z = Input.GetAxis("Vertical") * speed;
        vel.x = Input.GetAxis("Horizontal") * speed;
        //Move up, down, left, and right with speed.

        vel = transform.TransformDirection(vel);
        //Move while you're facing direction.

        characterControl.Move(vel * Time.deltaTime);
        //Have the player move around with velocity and Time.deltaTime.
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
            //Reuse a bullet based on one or more disabled object.
        }
        //Do the following task for the array list inside void CreateBulletPool().
    }
}
