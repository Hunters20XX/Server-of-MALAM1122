using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject collect;
    public float number;
    public float choiceA;
    public float choiceB;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Debug.Log(i);
            Vector3 newPos = new Vector3(choiceA + (i * 2), transform.position.y, choiceB);
            Instantiate(collect, newPos, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
