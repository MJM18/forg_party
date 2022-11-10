using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLtoRx2 : MonoBehaviour
{
    float initialY;
    float randomValue;
    private GameObject AliveAnt;
    float initialX;
    float incrementer;
    float previousTime;
    void Start()
    {
        initialY = Random.Range(-3.5f, 3.5f);
        randomValue = Random.Range(-3.5f, 4.5f);

    }

    // Update is called once per frame
    void Update()
    {
        //Quisiera ser una mosca, para pararme en tu pieeeeeel (JV)
        transform.position = new Vector3(transform.position.x, Mathf.Sin((Time.time + randomValue) * 10) / 5, transform.position.z);
        transform.Translate(Time.deltaTime * 2, initialY, 0);
        detectTouch();
        if (transform.position.x >= 4)
        {
            Destroy(this, 0f);
            Marcador.vidas--;
        }
    }

    void detectTouch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.collider != null)
                {
                    GameObject touchedObject = hit.transform.gameObject;
                    Destroy(touchedObject, 0);
                    Marcador.score++;
                    Debug.Log("Touched " + touchedObject.transform.name);
                }
            }
        }
    }
}
