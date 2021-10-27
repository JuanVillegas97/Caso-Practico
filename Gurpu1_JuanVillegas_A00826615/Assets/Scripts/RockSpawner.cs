using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public float spawnDelay=1;    
    private int xPos;
    private float nextSpawnTime;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ShouldSpawn()){
            Spawn();
        }
    }

    private void Spawn(){
        xPos = Random.Range(-4, 4);
        nextSpawnTime = Time.time+spawnDelay;
        Instantiate(prefab, new Vector3(xPos, 6, 0), Quaternion.identity);

    }
    private bool ShouldSpawn(){
        return Time.time>=nextSpawnTime;
    }
}
