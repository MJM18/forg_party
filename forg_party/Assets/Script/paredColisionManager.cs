using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredColisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject flyDetected = GameObject.Find("x");
        Marcador.vidas -= 1;
        Destroy(flyDetected);
    }
}
