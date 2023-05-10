using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidNote : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    public float threshold;
    public bool dead;
    public float beatTempo;
    public bool moving;
    public float time;
    public bool timer;
    public bool firsthit = false;
    FrenzyMode frenzy;
    private SpriteRenderer theSR;
    public Sprite pressedImage;
    Gameplay game;
    ButtonController bc;
    public AudioSource swing;


    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        frenzy = GameObject.Find("vampire_neutral").GetComponent<FrenzyMode>();
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
        bc = GameObject.Find("vampire_neutral").GetComponent<ButtonController>();
        beatTempo = beatTempo / 60f;
        moving = true;
        timer = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
        }

        


        if (Input.GetKeyDown(keyToPress) && game.pause == false)
        {
            if (canBePressed)
            {
                theSR.sprite = pressedImage;

                moving = false;

                timer = true;

                if(firsthit == false)
                {
                    GameObject.Find("Button1").GetComponent<Score>().hit++;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;

                    firsthit = true;
                    
                }

                //gameObject.SetActive(false);

                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim++;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score++;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 5;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }

                bc.attack = true;

            }
        }

        if (Input.GetKeyDown(keyToPress2) && game.pause == false)
        {
            if (canBePressed)
            {
                theSR.sprite = pressedImage;

                moving = false;

                timer = true;

                if (firsthit == false)
                {
                    GameObject.Find("Button1").GetComponent<Score>().hit++;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;

                    firsthit = true;

                }

                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim++;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score++;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 5;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }

                bc.attack = true;
            }
        }

        if (transform.position.x < threshold && dead == false)
        {
            GameObject.Find("Button1").GetComponent<Score>().multiplier -= 3;
            GameObject.Find("Button1").GetComponent<Score>().hit = 0;
            GameObject.Find("vampire_neutral").GetComponent<Health>().heart -= 3;
            frenzy.hitsInARow = 0;
            bc.hurt = true;
            swing.Play();
            dead = true;
        }

        if (timer)
        {
            time -= Time.deltaTime;
        }

        if (time < 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
    }

    void OnEnable()
    {
        dead = false;
    }

    void OnDisable()
    {
        dead = true;
    }
}