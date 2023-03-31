using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    public AudioSource playeraudio;
    public AudioClip door;

    public string itemName;
    //Publicly display the string with itemName.
    PlayerControl playerScript;
    //Use the PlayerControl for playerScript, as explained in void Start().
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerControl>();
        //Have the playerScript find the object player that has a component of PlayerControl and manage it from here.
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        Debug.Log(itemName);
        //Have the debug display the name of the item.
        playerScript.itemText.text = itemName;
        //Have the name be display using itemText.text from PlayerControl, but this time, as a door.
    }

    void OnMouseExit()
    {
        playerScript.itemText.text = "Nothing";
        //If the mouse is hovered away from the door, then label the text as "Nothing."
    }

    void OnMouseDown()
    {
        if (playerScript.hasAllKeys == true)
        {
            gameObject.SetActive(false);
            playeraudio = GameObject.Find("Player").GetComponent<AudioSource>();
            playeraudio.PlayOneShot(door);
        }
        //If the player has all the keys, thus labeling the bool "hasAllKeys" as true, and that the door is clicked on because of it, then that door opens and disappear, clearing the game in the progress.
    }

    void OnDisable()
    {
        
    }
}
