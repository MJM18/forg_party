using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntuacionFinal : MonoBehaviour
{
    public Text scoreFinal;
    void Start()
    {
        scoreFinal.text = Marcador.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreFinal.text = Marcador.score.ToString();
    }
}
