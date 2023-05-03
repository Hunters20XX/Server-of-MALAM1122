using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class PressStart : MonoBehaviour
{
    public GameObject startText;
    // Start is called before the first frame update
    void Start()
    {
        startText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
