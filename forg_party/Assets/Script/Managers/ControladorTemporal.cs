using UnityEngine;

public class ControladorTemporal : MonoBehaviour
{
    public static float temporizadorInGame;
    public float longitudHora;   //cada cuanto se realizan las actualizaciones(cambios en los estats comida, aburrimiento...)
    public static ControladorTemporal instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More Than one ControladorTemporal in the scene");
    }

    private void Update() 
    {
        if (temporizadorInGame <= 0) 
        {
            temporizadorInGame = longitudHora;
        }
        else {
            temporizadorInGame -= Time.deltaTime;
        }

    }
}
