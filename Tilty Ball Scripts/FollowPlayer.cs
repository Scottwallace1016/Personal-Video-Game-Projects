using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour {

    // Use this for initialization
    public Transform player;
    public Vector3 offset;


    // Update is called once per frame

    void Start()
    {
        Screen.SetResolution(Screen.width, Screen.height, true);
    }
    void Update()
    {
        transform.position = player.position + offset;

    }
}
