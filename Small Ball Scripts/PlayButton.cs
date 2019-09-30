using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class PlayButton : MonoBehaviour {
    public static bool gameStarted = false;
    

	public void PlayGame()
    {
        if (!Advertisement.isShowing)
        {
            SceneManager.LoadScene(3);
            gameStarted = true;
        }

        gameStarted = false;
 
       
        Trigger.counter = 0;
       
       
   
    }

}
