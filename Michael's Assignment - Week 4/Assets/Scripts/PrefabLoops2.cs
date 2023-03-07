using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabLoops2 : MonoBehaviour
{
    public GameObject collect;
    public float number;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Debug.Log(i);
            Vector3 newPos = new Vector3(transform.position.x + (i * 4), transform.position.y, transform.position.z - (i * 4));
            Instantiate(collect, newPos, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
