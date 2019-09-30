using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public float timeLeft = 5f;

 

    // Update is called once per frame
    void Update () {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
		
	}
}
