using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mission : MonoBehaviour
{
    public int keys = 0;
    //The player has no keys to begin with.
    public TMP_Text keyText;
    //Display the keyText into the canvas.
    public GameObject winText;
    //Use the text, winText, as an object for a purpose.
    public float threshold;
    //The threshold is here for a finish line.
    void Start()
    {
        keyText.text = "Keys: " + keys.ToString() + " / 48";
        //Display the keyText.text as "Keys: " with the int of keys.ToString() and end with " / 48," clearly displaying the goal for the door.
        winText.gameObject.SetActive(false);
        //The object stay disable until the threshold is reached.
    }

    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys: " + keys.ToString() + " / 48";
        //Do the same line here, from line 19.
        if (keys >= 48)
        {
            GameObject.Find("Player").GetComponent<PlayerControl>().hasAllKeys = true;
        }
        //If the player finds all the keys from each enemy, then the bool from the component, in turn the script "PlayerControl," hasAllKey is labeled as true.

        if (transform.position.z > threshold)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        //If the player goes over the threshold, after unlocking the door, then time freezes and the object of the winText is shown, finishing the game.
    }
}
