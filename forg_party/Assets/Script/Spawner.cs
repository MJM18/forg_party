using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] flies;
    public float minY, maxY, spawnRate;
    private float nextSpawn;

    void Start()
    {
        /*
        nextSpawn = Time.time;
        minY = 0.50;
        maxY = 4.2;
        */
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn();
    }
    /*
    void Spawn()
    {
        if (Time.time > nextSpawn)
        {
            Vector2 position = new Vector2(Random.Range(minY, maxY), transform.position.x);
            Instantiate(flies[Random.Range(0, flies.Length - 1)], new Vector2(position.x, position.y), transform.rotation);
            nextSpawn = Time.time + spawnRate;
        }
    }
    */
}
