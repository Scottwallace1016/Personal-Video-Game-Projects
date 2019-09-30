
using UnityEngine;
using UnityEngine.Advertisements;

public class FinishLine : MonoBehaviour
{
    public GameManager gameManager;
    public static bool adOn = false;
   

    public void OnTriggerEnter()
    {
        if (OnCollision.hit == false)
        {
            gameManager.CompleteLevel();
            gameManager.SaveGame();
            
            

        }
      

    }
}
