using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidad;
    AudioSource musica;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        rb.velocity = new Vector2(0, -velocidad);
        musica = FindObjectOfType<AudioSource>();
    }


    void Update()
    {
        //si te saltas una nota se para el juego -> habría que añadir algo para que no sea muy soso
        if (this.transform.position.y < -6)
        {
            //Debug.Log("HAS FALLADO");
            //musica.mute = true;
            //Time.timeScale = 0;
           // Destroy(this.gameObject);
        }

    }
}
