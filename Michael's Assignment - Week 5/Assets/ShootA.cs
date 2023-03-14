using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootA : MonoBehaviour
{
    public GameObject bullet;
    public float timeRemaining = 5;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

 

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else if (timeRemaining <= 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    Debug.Log(i);
                    Vector3 newPos = transform.position;
                    Instantiate(bullet, newPos, Quaternion.identity);
                }
                timeRemaining -= Time.deltaTime;
                timeRemaining = 5;
            }
        }

    }

}
