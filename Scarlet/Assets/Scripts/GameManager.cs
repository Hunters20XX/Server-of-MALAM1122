using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public BeatScroller theBS;

    public bool timer = false;
    public float time;

    Gameplay game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();

        timer = true;


        //StartCoroutine(MusicCoroutine());
    }

    /*IEnumerator MusicCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        theMusic.Play();
    }*/

    // Update is called once per frame
    void Update()
    {

        if (timer)
        {
            time -= Time.deltaTime;
        }

        if (time <= 0)
        {
            theMusic.Play();
            timer = false;
            time = 1;
        }

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