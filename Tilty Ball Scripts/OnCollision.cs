using UnityEngine;
using UnityEngine.Advertisements;

public class OnCollision : MonoBehaviour {
    public PlayerMovement movement;
    public GameManager manager;
    public static bool hit = false;
    public static int playCounter;

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            hit = true;
            Handheld.Vibrate();
            manager.EndGame();
        }
        else
        {
            hit = false;
        }


        if(playCounter >= 7)
        {
            if (Advertisement.IsReady("video"))
            {
                Advertisement.Show("video");
                playCounter = 0;
            }
        }
    }
}
