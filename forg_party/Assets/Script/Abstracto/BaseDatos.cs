using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class BaseDatos

{
    public static BaseDatos instance;
    private string path = Application.dataPath + "/partida/";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More Than one baseDatos in the scene");
    }
    public void GuardarDatos<T>(string nombreGuardado, T valorGuardar) {
        string jsonGuardado = JsonUtility.ToJson(valorGuardar);
        File.WriteAllText(path + nombreGuardado + ".json", jsonGuardado );
    }
    public void CargarDatos<T>(string nombreGuardado, System.Action<T> callback) 
    {
        if (File.Exists(path + nombreGuardado + ".json"))
        {
            string loadedJson = File.ReadAllText(path + nombreGuardado + ".json");
            callback(JsonUtility.FromJson<T>(loadedJson));
        }
        else 
        {
            Debug.Log("No hay fichero de partida");
        }
    }

}
