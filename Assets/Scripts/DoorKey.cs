using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorKey : MonoBehaviour
{
    public bool hasKey = false;
    
    void Awake()
    {
       
    }


    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            hasKey = true;
            gameObject.SetActive(false);
        }
    }
}
