using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] blocks;
    public float minTime;
    public float maxTime;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", Random.Range(minTime, maxTime), Random.Range(minTime, maxTime));
    }

    void SpawnEnemy()
    {
        Instantiate(blocks[Random.Range(0, 3)], transform.position, transform.rotation);
    }
}
