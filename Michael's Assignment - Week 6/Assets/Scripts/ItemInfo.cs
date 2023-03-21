using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInfo : MonoBehaviour
{
    public string itemName;
    public int itemValue;
    PlayerControl playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(false);
    }
    
    void OnMouseOver()
    {
        Debug.Log(itemName);
        playerScript.itemText.text = itemName;
    }

    void OnMouseExit()
    {
        playerScript.itemText.text = "Nothing!";
    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
