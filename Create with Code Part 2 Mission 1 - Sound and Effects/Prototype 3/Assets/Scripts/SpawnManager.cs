using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public float statDelay = 2;
    public float repeatTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", statDelay, repeatTime);
    }

    void SpawnObstacle(){
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

    public void StopSpawning(){
        CancelInvoke("SpawnObstacle");
    }

}
