using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingD : MonoBehaviour
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
        if (transform.position.x >= thresholdA)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(numberA, 0, 0);
        }
        if (transform.position.x <= thresholdB)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(numberB, 0, 0);
        }
    }
}