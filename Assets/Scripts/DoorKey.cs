using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorKey : MonoBehaviour
{
    public bool hasKey = false;

    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
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
