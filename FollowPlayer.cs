using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform player;
    public Vector3 offset;
    private GameObject coin;
    

	// Update is called once per frame
	void FixedUpdate () {
        coin = GameObject.FindGameObjectWithTag("Coin");
        transform.position = player.position + offset;
        if(transform.position.z > coin.transform.position.z)
        {
            Destroy(coin);
        }
        


	}
}
