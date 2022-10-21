using UnityEngine;

public class ControladorTemporal : MonoBehaviour
{
    public static float temporizadorInGame, temporizadorInGameIra;       //contador con el tiempo de 
    public float longitudHora, longitudHoraIra;   //cada cuanto se realizan las actualizaciones(cambios en los estats comida, aburrimiento...)

    private void Update() 
    {
        if (temporizadorInGame <= 0) 
        {
            temporizadorInGame = longitudHora;
        }
        else {
            temporizadorInGame -= Time.deltaTime;
        }

        if (temporizadorInGameIra <= 0)
        {
            temporizadorInGameIra = longitudHoraIra;
        }
        else
        {
            temporizadorInGameIra -= Time.deltaTime;
        }
    }
}
