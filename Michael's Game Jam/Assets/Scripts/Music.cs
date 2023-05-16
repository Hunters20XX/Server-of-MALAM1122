using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Music : MonoBehaviour
{
    public AudioSource audioSourceIntro;
    public AudioSource audioSourceLoop;
    private bool startedLoop;

    DeltaTime clock;

    void Start()
    {
        clock = GameObject.Find("Player").GetComponent<DeltaTime>();
    }

    void FixedUpdate()
    {
        if (!audioSourceIntro.isPlaying && !startedLoop)
        {
            audioSourceLoop.Play();
            Debug.Log("Done playing");
            startedLoop = true;
        }

    }

    void Update()
    {

        if (clock.finished == true)
        {
            audioSourceIntro.Stop();
            audioSourceLoop.Stop();
            startedLoop = false;
        }
    }

}
