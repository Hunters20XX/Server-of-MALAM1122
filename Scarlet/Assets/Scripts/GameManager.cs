using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public BeatScroller theBS;

    bool pausedMusic = false;

    Gameplay game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();

        theMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && game.end == false)
        {
            if (game.pause == true)
            {
                theMusic.Pause();
            }

            if (game.pause == false)
            {
                theMusic.Play();
            }
        }

    }
}
