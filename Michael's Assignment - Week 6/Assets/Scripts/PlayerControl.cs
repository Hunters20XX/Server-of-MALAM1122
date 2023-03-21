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
        itemText.text = lookingAt;
    }

    public float speed;
    public float upRotation;
    public float downRotation;

    public TMP_Text itemText;
    public string lookingAt = "Nothing!";

    CharacterController characterControl;
    public Transform playerCam;

    Vector3 vel;
    public float lookSensitivity;

    float xRotation = 0;

    public GameObject bulletPrefab;

    public bool hasKey = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody>().velocity = 2 * transform.forward;
        }

        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
            xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
            xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
            playerCam.localRotation = Quaternion.Euler(xRotation, 0, 0);

           
        }
        vel.z = Input.GetAxis("Vertical") * speed;
        vel.x = Input.GetAxis("Horizontal") * speed;

        vel = transform.TransformDirection(vel);
        characterControl.Move(vel * Time.deltaTime);
    }
}
