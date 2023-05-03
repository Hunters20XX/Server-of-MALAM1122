using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenzyMode : MonoBehaviour
{
    public int hitsInARow;
    public int frenzyLine;
    public bool frenzyMode;
    GameObject aura;

    // Start is called before the first frame update
    void Start()
    {
        aura = GameObject.Find("frenzy mode");
    }

    // Update is called once per frame
    void Update()
    {
        if(hitsInARow >= frenzyLine)
        {
            frenzyMode = true;
            aura.SetActive(true);
        }

        if(hitsInARow <= frenzyLine)
        {
            frenzyMode = false;
            aura.SetActive(false);
        }
    }
}
