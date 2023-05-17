using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserB : MonoBehaviour
{
    public ConstantForce Change;
    public GameObject enemy;
    public float numberA;
    public float numberB;

    public bool properStart = false;

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

        if (clock.levelCount == 100 && GameObject.Find("Laser Wall (A)").GetComponent<LaserA>().transform.position.x <= -12 && GameObject.Find("Laser Wall (B)").GetComponent<LaserA>().transform.position.x >= 12)
        {
            properStart = true;
        }

        if (properStart == true)
        {
            if (transform.position.z >= 12)
            {
                if (clock.levelCount >= 100)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB);
                }
                if (clock.levelCount >= 110)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 4);
                }
                if (clock.levelCount >= 120)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 8);
                }
                if (clock.levelCount >= 130)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 12);
                }
                if (clock.levelCount >= 140)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 16);
                }
                if (clock.levelCount >= 150)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 20);
                }
                if (clock.levelCount >= 160)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 24);
                }
                if (clock.levelCount >= 170)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 28);
                }
                if (clock.levelCount >= 180)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 32);
                }
                if (clock.levelCount >= 190)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 36);
                }
                if (clock.levelCount >= 200)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB - 40);
                }
            }

            if (transform.position.z <= -12)
            {
                if (clock.levelCount >= 100)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA);
                }
                if (clock.levelCount >= 110)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 4);
                }
                if (clock.levelCount >= 120)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 8);
                }
                if (clock.levelCount >= 130)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 12);
                }
                if (clock.levelCount >= 140)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 16);
                }
                if (clock.levelCount >= 150)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 20);
                }
                if (clock.levelCount >= 160)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 24);
                }
                if (clock.levelCount >= 170)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 28);
                }
                if (clock.levelCount >= 180)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 32);
                }
                if (clock.levelCount >= 190)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 36);
                }
                if (clock.levelCount >= 200)
                {
                    enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA + 40);
                }
            }
        }     
    }
}
