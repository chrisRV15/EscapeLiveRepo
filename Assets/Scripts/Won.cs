using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Won : MonoBehaviour
{
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
        if (other.gameObject.name == "Finish") 
        {
            setTimer(0);
        }

    }

    void setTimer(int time)
    {
        Timer playerTimer = this.GetComponent<Timer>();
        playerTimer.startTimer = time;
    }

}
