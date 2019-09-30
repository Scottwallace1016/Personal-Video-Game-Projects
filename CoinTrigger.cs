using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour {
    private GameObject player;
    private GameObject[] coins;
    private GameObject coin;  





    // Use this for initialization
    private void OnTriggerEnter()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin");
        player = GameObject.FindGameObjectWithTag("Player") as GameObject;
        player.transform.localScale = new Vector3(.8f, .8f, .8f); 

      
        Destroy(coins[0]);

    }
    }


