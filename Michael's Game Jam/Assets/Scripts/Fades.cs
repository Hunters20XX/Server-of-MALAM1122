using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fades : MonoBehaviour
{
    DeltaTime clock;

    public TMP_Text Pop;
    Color col;
    Color zap;

    public float level;
    public bool flag = false;

    public float beep = 5;

    // Start is called before the first frame update
    void Start()
    {
        clock = GameObject.Find("Player").GetComponent<DeltaTime>();

        col = Pop.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (clock.levelCount == level && flag == false)
        {
            flag = true;
        }

        if (flag == true)
        {
            beep -= Time.deltaTime;
            if (col.a < 254)
            {
                col.a += 1f * Time.deltaTime;
                Pop.color = col;
            }
            if (col.a > 255)
            {
                col.a = 255;
            }
        }
        if (beep < 0)
        {
            beep = 0;
            col.a -= 2f * Time.deltaTime;
            Pop.color = col;
        }
    }
}