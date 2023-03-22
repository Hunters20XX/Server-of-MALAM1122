using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbBullets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider otherThing)
    {
        if (otherThing.gameObject.tag == "Bullet")
        {
            otherThing.gameObject.SetActive(false);
        }
    }
}
