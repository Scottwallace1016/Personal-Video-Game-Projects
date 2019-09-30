using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Timer : MonoBehaviour {
    public float timeLeft = 60f;
    public GameManager manager;
    public Text timerText;
    

    // Update is called once per frame
  
    void Update () {
        if (!Advertisement.isShowing)
        {
            timeLeft -= Time.deltaTime;

            if (timeLeft < 0)
            {
                manager.Restart();


            }
            timerText.text = timeLeft.ToString("0");

        }

    }
       
        
        
    }

