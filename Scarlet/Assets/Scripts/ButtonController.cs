using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public Sprite hurtImage;

    public AudioSource hit;
    public AudioSource grunt;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;

    public bool hold = false;
    public bool hurt = false;
    public bool attack = false;

    Gameplay game;


    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
        theSR = GetComponent<SpriteRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyToPress) || Input.GetKey(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKey(keyToPress) && Input.GetKey(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }
        if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }

        if (game.end == false)
        {
            if (game.pause == false)
            {
                if (Input.GetKey(keyToPress) || Input.GetKey(keyToPress2))
                {
                    theSR.sprite = pressedImage;                
                }
                if (Input.GetKey(keyToPress) && Input.GetKey(keyToPress2))
                {
                    theSR.sprite = pressedImage;
                }
                if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
                {
                    theSR.sprite = defaultImage;
                }
                if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
                {
                    theSR.sprite = defaultImage;
                }

            }

            if (Input.GetKeyDown(KeyCode.LeftShift) && game.pause == true)
            {
                if (hold == false)
                {
                    theSR.sprite = defaultImage;
                }
            }



            if(hurt)
            {
                theSR.sprite = hurtImage;
                hurt = false;
                grunt.Play();
            }

            if(attack)
            {
                hit.Play();
                attack = false;
            }
        }
    }
}