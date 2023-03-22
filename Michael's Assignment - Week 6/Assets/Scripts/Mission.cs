using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mission : MonoBehaviour
{
    public int keys = 0;
    public TMP_Text keyText;
    public GameObject winText;
    public float threshold;
    // Start is called before the first frame update
    void Start()
    {
        keyText.text = "Keys: " + keys.ToString() + " / 48";
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys: " + keys.ToString() + " / 48";
        if (keys >= 48)
        {
            GameObject.Find("Player").GetComponent<PlayerControl>().hasAllKeys = true;
        }

        if (transform.position.z > threshold)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
