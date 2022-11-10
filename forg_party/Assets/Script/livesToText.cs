using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livesToText : MonoBehaviour
{
    public Text livesText;
    void Start()
    {
        livesText.text = Marcador.vidas.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = Marcador.vidas.ToString();
    }
}
