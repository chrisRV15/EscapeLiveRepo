using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour
{
    public DoorKey myKey;

    // Start is called before the first frame update
    void Start()
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
            if (myKey.hasKey == true)
            {
                gameObject.SetActive(false);
            }
        }
    }

}
