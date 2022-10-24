using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botones : MonoBehaviour
{
    bool activo = false;                        //detecta contacto boton-nota
    GameObject nota;                            //nota detectada
    SpriteRenderer sr;                          //componente (para el color) de los botones
    Color old;                                  // color inicial de notas

    public GameObject crear_nota;
    public bool createMode;                     //esta variable es para crear la notas en ejecucion...
    public KeyCode key;                         //para facilitar la creacion de notas en ejecucion -> teclas A, S, D, F


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        old = sr.color;
    }


    void Update()
    {
        //para la creacion de las notas segun el ritmo de la musica, es manual
        if(createMode)
        {
            if (Input.GetKeyDown(key))
                Instantiate(crear_nota, transform.position, Quaternion.identity);
        }
        else
        {
            //si pulsa tecla vinculada al boton empieza la corrutina
            if (Input.GetKeyDown(key))
                StartCoroutine("Boton_Down");

            //si detecta colision y se ha pulsado la tecla vinculada a ese boton borra la nota
            if (Input.GetKeyDown(key) & activo)
            {
                Destroy(nota);
            }

        }
        
    }


    //el que realmente detecta el contacto entre colliders
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Notas")
        {
            activo = true;
            nota = collision.gameObject;
        }

        if(collision.gameObject.tag == "Nota_Final") 
        {
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        activo = false;
    }

    //corrutina encargada de cambiar el color de los botones al pulsarlos...
    IEnumerator Boton_Down()
    {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.1f);
        sr.color = old;
    }
}
