using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public AudioSource ded;
    public AudioClip puff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Poof", 2.0f);
    }

    void Poof()
    {
        gameObject.SetActive(false);
        ded = GameObject.Find("Player").GetComponent<AudioSource>();
        ded.PlayOneShot(puff);
    }

    void OnDisable()
    {
        CancelInvoke("Poof");
    }
}
