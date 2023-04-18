using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeOut : MonoBehaviour
{
    public TMP_Text Panel;
    Color col;
    void Start()
    {
        col = Panel.color;
    }

    // Update is called once per frame
    void Update()
    {        
            Invoke("GoodLuck", 5.0f);
    }
    void GoodLuck ()
    {
        if (col.a > 0)
        {
            col.a -= Time.deltaTime;
            Panel.color = col;
        }
    }
}
