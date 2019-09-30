using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class TouchAnywhere : MonoBehaviour
{
    public GameManager manager;
    public Text text;
    public Timer time;
    public PlayerMovement movement;
    public AutoSave autoSave;

    // Update is called once per frame
    void FixedUpdate()
    {
        text.enabled = false;
        time.enabled = false;
        movement.enabled = false;
        
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began && !Advertisement.isShowing)
                {
                    manager.NextLevel();

                }

            }

        }
     
    }
