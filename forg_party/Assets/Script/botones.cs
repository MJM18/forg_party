using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botones : MonoBehaviour
{
    bool activo = false;
    GameObject nota;
    SpriteRenderer sr;
    Color old;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        old = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
            StartCoroutine("Boton_Down");

        if (Input.GetMouseButtonDown(0) & activo) 
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

    IEnumerator Boton_Down()
    {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.1f);
        sr.color = old;
    }
}
