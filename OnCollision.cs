using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class OnCollision : MonoBehaviour
{
    public GameManager manager;
    public PlayerMovement pm;
    public static int deathCounter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
           
            Handheld.Vibrate();
            pm.enabled = false;
            deathCounter++;
            manager.EndGame();

            if (deathCounter >= 7)
            {
                if (Advertisement.IsReady("video"))
                {
                    Advertisement.Show("video");
                   
                    deathCounter = 0;
                }
               
            }

        }

    }
   
}
