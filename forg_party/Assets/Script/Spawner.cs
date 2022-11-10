using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] flies1;
    public GameObject[] flies2;
    public GameObject[] flies4;
    public GameObject[] flies8;
    public float minY, maxY, spawnRate;
    private float nextSpawn;
    int indexFly;
    Vector3 position;
    public Collider paredDerecha;

    void Start()
    {
        nextSpawn = Time.time;
        minY = 0f;
        maxY = 4.3f;
        spawnRate = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Marcador.vidas == 0)
        {

        }
        else
        {
            if (Marcador.score <= 10)
            {
                Spawn();
            }
            else if (Marcador.score <= 35)
            {
                Spawn2();
            }
        }
    }

    void Spawn()
    {
        if (Time.time >= nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            indexFly = Random.Range(0, flies1.Length - 1);
            GameObject clone = Instantiate(flies1[indexFly], new Vector3(-3.31f, position.y), transform.rotation);
        }
    }

    void Spawn2()
    {
        if (Time.time >= nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            indexFly = Random.Range(0, flies2.Length - 1);
            GameObject clone1 = Instantiate(flies1[indexFly], new Vector3(-3.31f, Random.Range(-3.5f, 3.5f)), transform.rotation);
            GameObject clone2 = Instantiate(flies2[indexFly], new Vector3(-3.31f, Random.Range(-3.5f, 3.5f)), transform.rotation);
        }
    }
}
