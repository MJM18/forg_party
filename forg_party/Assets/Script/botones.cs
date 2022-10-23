using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botones : MonoBehaviour
{
    bool activo = false;
    GameObject nota;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) & activo) 
        {
            Destroy(nota);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        activo = true;
        if(collision.gameObject.name == "Nota")
        {
            nota = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        activo = false;
    }
}
