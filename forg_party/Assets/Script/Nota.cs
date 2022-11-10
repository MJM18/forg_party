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

    }
}
