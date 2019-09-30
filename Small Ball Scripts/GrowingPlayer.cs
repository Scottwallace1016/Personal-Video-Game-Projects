using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingPlayer : MonoBehaviour {
    public Transform player;
    public float sizeIncrease = 0.1f; 

	
	// Update is called once per frame
	void FixedUpdate () {
        player.localScale += new Vector3(sizeIncrease * Time.deltaTime, sizeIncrease * Time.deltaTime, sizeIncrease * Time.deltaTime);
	}
}
