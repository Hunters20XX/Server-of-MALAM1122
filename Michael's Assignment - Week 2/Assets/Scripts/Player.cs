using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float thisIsADecimal = 3.14f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(thisIsADecimal);
        thisIsADecimal++;
        Debug.Log(thisIsADecimal);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(7, 0, 5);

        Vector3 newPos = transform.position;

        if (Input.GetKey (KeyCode.D))
        {
            newPos.x+= 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x-= 0.1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            newPos.z+= 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.z-= 0.1f;
        }
        transform.position = newPos;
    }
}
