using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLtoR : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Quisiera ser una mosca, para pararme en tu pieeeeeel (JV)
        CalculatePos();
        
    }

    void CalculatePos(){
        if(timer >= 4.5f) {
        transform.position = new Vector3(transform.position.x, Random.Range(0,6), transform.position.z);
        transform.Translate(Time.deltaTime, 0, 0);
        timer = 0;
        }
    }
}
