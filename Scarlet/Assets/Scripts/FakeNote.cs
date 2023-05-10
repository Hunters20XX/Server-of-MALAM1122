using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeNote : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    public bool fail;

    FrenzyMode frenzy;
    Gameplay game;
    ButtonController bc;

    public AudioSource poof;

    // Start is called before the first frame update
    void Start()
    {
        frenzy = GameObject.Find("vampire_neutral").GetComponent<FrenzyMode>();
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
        bc = GameObject.Find("vampire_neutral").GetComponent<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && game.pause == false)
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().multiplier -= 2;
                GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                fail = true;
                GameObject.Find("vampire_neutral").GetComponent<Health>().heart -= 2;
                frenzy.hitsInARow = 0;
                bc.hurt = true;
                poof.Play();
            }
        }

        if (Input.GetKeyDown(keyToPress2) && game.pause == false)
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().multiplier -= 2;
                GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                fail = true;
                GameObject.Find("vampire_neutral").GetComponent<Health>().heart -= 2;
                frenzy.hitsInARow = 0;
                bc.hurt = true;
                poof.Play();
            }
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
        fail = false;
    }

    void OnDisable()
    {
        fail = true;
    }
}