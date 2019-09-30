using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class GameManager : MonoBehaviour {
  

    public float restartDelay = 0.5f;

    public void EndGame()
    {
        Invoke("Restart", restartDelay);
    }

    public void Restart()
    {
        SceneManager.LoadScene(2);
        
      

    }
  

   


}
