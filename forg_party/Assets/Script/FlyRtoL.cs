using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyRtoL : MonoBehaviour
{
    // Start is called before the first frame update
    int neg = -1;
    float initialY;
    float randomValue;
    private GameObject AliveAnt;

    void Start()
    {
        //initialY = Random.Range(0, 4.5f);
        //randomValue = Random.Range(0, 4.5f);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        transform.position = new Vector3(transform.position.x * neg, Mathf.Sin((Time.time + randomValue) * 10) / 5, transform.position.z);
        transform.Translate(-Time.deltaTime, initialY, 0);
        */
    }
}
