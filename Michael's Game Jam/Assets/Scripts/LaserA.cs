using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserA : MonoBehaviour
{
    public ConstantForce Change;
    public GameObject laser;
    public float numberA;
    public float numberB;

    DeltaTime clock;
    // Start is called before the first frame update
    void Start()
    {
        clock = GameObject.Find("Player").GetComponent<DeltaTime>();
    }

    // Update is called once per frame
    void Update()
    {
        Change = GetComponent<ConstantForce>();

        

        if (transform.position.x >= 12)
        {
            if (clock.levelCount >= 50)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB, 0, 0);
            }
            if (clock.levelCount >= 60)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 4, 0, 0);
            }
            if (clock.levelCount >= 70)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 8, 0, 0);
            }
            if (clock.levelCount >= 80)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 12, 0, 0);
            }
            if (clock.levelCount >= 90)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 16, 0, 0);
            }
            if (clock.levelCount >= 100)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 20, 0, 0);
            }
            if (clock.levelCount >= 110)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 24, 0, 0);
            }
            if (clock.levelCount >= 120)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 28, 0, 0);
            }
            if (clock.levelCount >= 130)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 32, 0, 0);
            }
            if (clock.levelCount >= 140)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 36, 0, 0);
            }
            if (clock.levelCount >= 150)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 40, 0, 0);
            }
            if (clock.levelCount >= 160)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 44, 0, 0);
            }
            if (clock.levelCount >= 170)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 48, 0, 0);
            }
            if (clock.levelCount >= 180)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 52, 0, 0);
            }
            if (clock.levelCount >= 190)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 56, 0, 0);
            }
            if (clock.levelCount >= 200)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberB - 60, 0, 0);
            }
        }

        if (transform.position.x <= -12)
        {
            if (clock.levelCount >= 50)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA, 0, 0);
            }
            if (clock.levelCount >= 60)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 4, 0, 0);
            }
            if (clock.levelCount >= 70)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 8, 0, 0);
            }
            if (clock.levelCount >= 80)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 12, 0, 0);
            }
            if (clock.levelCount >= 90)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 16, 0, 0);
            }
            if (clock.levelCount >= 100)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 20, 0, 0);
            }
            if (clock.levelCount >= 110)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 24, 0, 0);
            }
            if (clock.levelCount >= 120)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 28, 0, 0);
            }
            if (clock.levelCount >= 130)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 32, 0, 0);
            }
            if (clock.levelCount >= 140)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 36, 0, 0);
            }
            if (clock.levelCount >= 150)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 40, 0, 0);
            }
            if (clock.levelCount >= 160)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 44, 0, 0);
            }
            if (clock.levelCount >= 170)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 48, 0, 0);
            }
            if (clock.levelCount >= 180)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 52, 0, 0);
            }
            if (clock.levelCount >= 190)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 56, 0, 0);
            }
            if (clock.levelCount >= 200)
            {
                laser.GetComponent<ConstantForce>().force = new Vector3(numberA + 60, 0, 0);
            }
        }
    }
}
