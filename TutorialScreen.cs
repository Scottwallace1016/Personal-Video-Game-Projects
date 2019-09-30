using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScreen : MonoBehaviour
{
    public PlayerMovement pm;
    public GrowingPlayer gp;
    public GameObject pane;

    private void Start()
    {
        if(PlayerPrefs.GetInt("Tutorial") == 1)
        {
            pane.SetActive(false);
            pm.enabled = true;
            gp.enabled = true;
         
        }
        else
        {
            pane.SetActive(true);
            pm.enabled = false;
            gp.enabled = false;
        }
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                PlayerPrefs.SetInt("Tutorial", 1);
                pane.SetActive(false);
                pm.enabled = true;
                gp.enabled = true;
            }
        }
    }
   
}
