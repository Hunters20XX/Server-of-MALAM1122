using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    Vector3 vel;
    public float speed;

    public CharacterController cc;
    CharacterController characterControl;


    public float gravity = -10f;
    public float gravityScale = 1;
    public float jumpHeight = 4;
    float velocity;
    // Start is called before the first frame update
    void Start()
    {
        characterControl = GetComponent<CharacterController>();
        Time.timeScale = 1.0f;
    }

    void MovePlayer()
    {
        cc.Move(new Vector3(0, velocity, 0) * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        vel.z = Input.GetAxis("Vertical") * speed;
        vel.x = Input.GetAxis("Horizontal") * speed;
        vel = transform.TransformDirection(vel);

        if (Input.GetKey(KeyCode.Space) && cc.isGrounded)
        {
            velocity = Mathf.Sqrt(jumpHeight * -3f * (gravity * gravityScale));
            // Jump !!
        }

        velocity += gravity * gravityScale * Time.deltaTime;
        characterControl.Move(vel * Time.deltaTime);
    }
}
