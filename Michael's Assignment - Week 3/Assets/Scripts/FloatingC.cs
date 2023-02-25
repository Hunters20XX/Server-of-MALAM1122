using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingC : MonoBehaviour
{
    public ConstantForce Change;
    public GameObject enemy;
    public float numberA;
    public float numberB;
    public float thresholdA;
    public float thresholdB;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Change = GetComponent<ConstantForce>();
        if (transform.position.z <= thresholdB)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB);
        }
        if (transform.position.z >= thresholdA)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA);
        }

    }
}