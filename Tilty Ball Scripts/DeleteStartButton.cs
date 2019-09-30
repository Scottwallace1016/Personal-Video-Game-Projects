using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeleteStartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject start = GameObject.FindGameObjectWithTag("Start");
        GameObject resume = GameObject.FindGameObjectWithTag("Resume");
        resume.SetActive(false);
        if (PlayerPrefs.GetInt("Start") == 1)
        {
            start.SetActive(false);
            resume.SetActive(true);
        }
    
    }
}
