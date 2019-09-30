using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    

   
    

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, 530 * Time.deltaTime);  // Constantly moving forward
        
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2)
                {
                    //rb.velocity = new Vector3(-400 * Time.deltaTime, 0, 0);
                    rb.AddForce(-20000 * Time.deltaTime, 0, 0);
                }
                else if (touch.position.x > Screen.width / 2)
                {
                    //rb.velocity = new Vector3(400 * Time.deltaTime, 0, 0);
                    rb.AddForce(20000 * Time.deltaTime, 0, 0);
                }

            }

        }
   

    }

 
  

}
