using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour {
    public Text text;
    public int sceneCount;

	// Use this for initialization
	void Update () {
     
        text.text = SceneManager.GetActiveScene().name;
    }
	
}
