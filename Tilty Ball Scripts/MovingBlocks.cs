using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocks : MonoBehaviour {

    public bool dirRight = true;
    public float speed = 2.0f;
    public float distanceRight = 4.0f;
    public float distanceLeft = -4;
  

	
	// Update is called once per frame
	void Update () {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if(transform.position.x >= distanceRight)
        {
            dirRight = false;
        }
        if(transform.position.x <= distanceLeft)
        {
            dirRight = true;
        }
     
	}
}
