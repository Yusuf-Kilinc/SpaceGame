using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] Obstacle;
    public float maxx;
    public float minx;
    public float maxY;
    public float miny;
    public float TimeBetweenSpawn;
    private float SpawnTime;
    public List<GameObject> SpawnList;


    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float X = Random.Range(minx, maxY);
        float Y = Random.Range(miny, maxx);
        Instantiate(Obstacle[Random.Range(0,3)], transform.position + new Vector3(X, Y, 0), transform.rotation);
    }


}
