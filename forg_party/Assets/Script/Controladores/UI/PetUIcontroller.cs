using UnityEngine;
using UnityEngine.UI;

public class PetUIcontroller : MonoBehaviour
{
    public Image imagenComida, imagenAburrimiento, imagenEnergia;

    public static PetUIcontroller instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("Mas de una PetUIController en escena");
    }

    public void UpdateImagenes(int comida, int aburrimiento,int energia) 
    {
        imagenComida.fillAmount =(float) comida / 100;
        imagenAburrimiento.fillAmount = (float) aburrimiento / 100;
        imagenEnergia.fillAmount = (float) energia / 100;
    }
}
