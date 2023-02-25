using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootD : MonoBehaviour
{
    public GameObject bullet;
    public ConstantForce shoot;
    public float choiceA;
    public float choiceB;
    public float numberA;
    public float numberB;
    public float target;
    // Start is called before the first frame update
    void Start()
    {
        bullet.gameObject.SetActive(false);
    }

    void Respawn()
    {
        transform.position = new Vector3(choiceA, 1, choiceB);
        bullet.GetComponent<ConstantForce>().force = new Vector3(numberA, 0, numberB);
        bullet.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= target)
        {
            bullet.gameObject.SetActive(false);
        }
    }

    void OnDisable()
    {
        InvokeRepeating("Respawn", 5.0f, 5.0f);
    }

    void OnEnable()
    {
        CancelInvoke("Respawn");
    }
}
