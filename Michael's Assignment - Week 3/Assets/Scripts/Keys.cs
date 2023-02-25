using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Keys : MonoBehaviour
{
    private int count;
    public GameObject Lock;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Lock.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }

        if (other.gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (count == 9)
        {
            Lock.SetActive(false);
        }
    }
}
