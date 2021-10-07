using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text timer;
    public GameObject losePanel;
    private float timep;
    public int countDown = 120;
    public float startTimer;
    

    // Start is called before the first frame update
    void Start()
    {
        startTimer = 1;
        downTimer();
        losePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void downTimer()
    {
        if (startTimer > 0)
        {
            if (countDown > 0)
            {
                TimeSpan spanTime = TimeSpan.FromSeconds(countDown);
                timer.text = "   " + spanTime.Minutes + " : " + spanTime.Seconds;
                countDown--;
                Invoke("downTimer", 1.0f);
            }
            else
            {
                losePanel.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
    }
   
   
}
