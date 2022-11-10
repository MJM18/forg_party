using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBaseDatos : MonoBehaviour
{
    public static ControladorBaseDatos instance;
    public BaseDatos database;
    public ControladorNecesidades cNecesidades;

    private void Awake()
    {
        database = new BaseDatos();
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More Than one DatabaseManager in the scene");
    }

    public void Update()
    {

        if (ControladorTemporal.temporizadorInGame < 0)
        {
            Mascota pet = new Mascota(
                cNecesidades.ultimaVezAlimentado,
                cNecesidades.ultimaVezDormido,
                cNecesidades.ultimaVezEntretenido,
                cNecesidades.Comida,
                cNecesidades.Aburrimiento,
                cNecesidades.Energia);
            GuardarMascota(pet);
        }
    }

    public void Start()
    {
        Mascota pet = CargarMascota();
        if (pet != null) Debug.Log(CargarMascota().Energia);
    }

    public void GuardarMascota(Mascota pet)
    {
        database.GuardarDatos<Mascota>("mascota", pet);
    }

    public Mascota CargarMascota()
    {
        Mascota returnValue = null;
        database.CargarDatos<Mascota>("mascota", (pet) =>
        {
            returnValue = pet;
        });
        return returnValue;
    }

}