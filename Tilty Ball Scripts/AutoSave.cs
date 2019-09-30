using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AutoSave : MonoBehaviour {
    public void LoadGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));

    }
}
