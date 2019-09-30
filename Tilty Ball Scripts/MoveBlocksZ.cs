using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocksZ : MonoBehaviour {

    public bool dirDown= false;
    public float speed = 2.0f;
    public float distanceNorth = 4.0f;
    public float distanceSouth = -4;



    // Update is called once per frame
    void Update()
    {
        if (dirDown)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (transform.position.z >= distanceNorth)
        {
            dirDown = true;
        }
        if (transform.position.z <= distanceSouth)
        {
            dirDown = false;
        }

    }
}
