using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeverGround : MonoBehaviour {
    private Transform player;
    public GameObject[] ground;
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnZ = -5.0f;
    private float tileLength = 50.0f;
    private int amtOfTiles =3;
    private float safeZone = 50.0f;
    private int lastPrefabIndex = 0; 



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < amtOfTiles; i++)
        {
            SpawnTile();

        } 
    }

    private void Update()
    {
        if(player.transform.position.z - safeZone > (spawnZ - amtOfTiles * tileLength))
        {
            SpawnTile();
            DeleteTile();
            
        }
        
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(ground[RandomPrefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);

    }

    private int RandomPrefabIndex()
    {
        if(ground.Length <= 1)
        {
            return 0;
        }
        int randomIndex = lastPrefabIndex;
        while(randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, ground.Length);

        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }

}
