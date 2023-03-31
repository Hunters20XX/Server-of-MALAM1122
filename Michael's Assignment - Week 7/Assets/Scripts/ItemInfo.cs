using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInfo : MonoBehaviour
{
    public AudioSource playeraudio;
    public AudioClip key;

    public string itemName;
    //Publicly display the string with itemName.
    PlayerControl playerScript;
    //Use the PlayerControl for playerScript, as explained in void Start().
    // Start is called before the first frame update
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
        //Have the name be display using itemText.text from PlayerControl.
    }

    void OnMouseExit()
    {
        playerScript.itemText.text = "Nothing";
        //If the mouse is hovered away from an item, then label the text as "Nothing."
    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameObject.Find("Player").GetComponent<Mission>().keys += 1;
        //If an item is clicked on, it disappears and goes to the script "Mission" to add a key by 1.


    } 

    void OnDisable()
    {
            playeraudio = GameObject.Find("Player").GetComponent<AudioSource>();
            playeraudio.PlayOneShot(key);
    }
}
