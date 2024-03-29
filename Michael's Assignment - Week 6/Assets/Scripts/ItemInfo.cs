using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInfo : MonoBehaviour
{
    public string itemName;
    PlayerControl playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void OnMouseOver()
    {
        Debug.Log(itemName);
        playerScript.itemText.text = itemName;
    }

    void OnMouseExit()
    {
        playerScript.itemText.text = "Nothing";
    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameObject.Find("Player").GetComponent<Mission>().keys += 1;
    } 
}
