using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainScroll : MonoBehaviour
{

    public float threshold;
    public float beatTempo;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f, 0f);

        if (transform.position.x < threshold)
        {
            transform.position = new Vector3(29f, -0.84f, 0);
        }
    }
}