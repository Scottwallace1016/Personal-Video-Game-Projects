using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour {
	// Update is called once per frame
	public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }
}
