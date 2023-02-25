using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingA : MonoBehaviour
{
    public ConstantForce Change;
    public GameObject enemy;
    public float numberA;
    public float numberB;
    public float thresholdA;
    public float thresholdB;
    public float thresholdC;
    public float thresholdD;
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Change = GetComponent<ConstantForce>();
        if (transform.position.x >= thresholdA && transform.position.z >= thresholdC)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA);
        }
        if (transform.position.x >= thresholdA && transform.position.z <= thresholdD)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(numberA, 0, 0);
        }
        if (transform.position.x <= thresholdB && transform.position.z <= thresholdD)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB);
        }
        if (transform.position.x <= thresholdB && transform.position.z >= thresholdC)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(numberB, 0, 0);
        }
    }
}