using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public ConstantForce Change;
    public GameObject enemy;
    public float numberA;
    public float numberB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Change = GetComponent<ConstantForce>();
        if (transform.position.x >= 9 && transform.position.z >= 9)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(numberA, 0, 0);
        }
        if (transform.position.x <= -9 && transform.position.z >= 9)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA);
        }
        if (transform.position.x <= -9 && transform.position.z <= -9)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(numberB, 0, 0);
        }
        if (transform.position.x >= 9 && transform.position.z <= -9)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB);
        }
    }
}
