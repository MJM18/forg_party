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

    public int cont;                            //contador notas acertadas
    GameObject gameManager;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        old = sr.color;
        gameManager = GameObject.Find("GameManager");
    }


    void Update()
    {
        /*
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
                cont++;
                Destroy(nota);
            }

        }
        */
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("FUNCIONA");
                if (hit.collider != null)
                {
                    
                    switch (hit.collider.name) 
                    {
                        case "Boton_1": StartCoroutine("Boton_Down");
                                        if(activo) { cont++; Destroy(nota); }
                            break;
                        case "Boton_2": StartCoroutine("Boton_Down");
                                        if (activo) { cont++; Destroy(nota);}
                            break;
                        case "Boton_3": StartCoroutine("Boton_Down");
                                        if (activo) { cont++; Destroy(nota); }
                            break;
                        case "Boton_4": StartCoroutine("Boton_Down");
                                        if (activo) { cont++; Destroy(nota); }
                            break;
                        default: break;
                    }
                }
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
            gameManager.GetComponent<GameManager>().Fin();
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
