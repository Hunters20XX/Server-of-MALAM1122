using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : MonoBehaviour
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
    void Update()
    {
        Change = GetComponent<ConstantForce>();
        if (transform.position.z >= 10)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberB);
        }
        if (transform.position.z <= -10)
        {
            enemy.GetComponent<ConstantForce>().force = new Vector3(0, 0, numberA);
        }
    }
}
