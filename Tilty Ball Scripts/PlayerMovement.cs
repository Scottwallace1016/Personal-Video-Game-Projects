
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardSpeed = 4;
    public float sidewaySpeed = 5;
    
    
    
   


	// Update is called once per frame
	void FixedUpdate () {
        Vector3 tilt = new Vector3(Input.acceleration.x, 0.0f, 0.0f);
        Vector3 movement = new Vector3(0.0f, 0.0f, forwardSpeed);
        rb.velocity = tilt * sidewaySpeed;

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
           
            

            if(touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Began)
            {
                rb.velocity = movement * forwardSpeed;
       
            }
            
           
        }
        
        

        
		
	}
}
