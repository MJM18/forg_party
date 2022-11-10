using UnityEngine;
using System.Collections;
using System;

public class ControladorNecesidades : MonoBehaviour
{
    public GameObject bien, mal, regular;
    public int Comida, Aburrimiento , Energia, Suciedad ; //cantidad de los estats
    public int comidaTickRate, aburrimientoTickRate, energiaTickRate, suciedadTickRate; //cuanto cambiar los estats en cada una de sus actualizaciones
    public static ControladorNecesidades instance;
    public DateTime ultimaVezAlimentado, ultimaVezDormido, ultimaVezEntretenido;

    private void Awake()
    {
        inicializar(100, 100, 100, 100 ,4 , 8, 6, 3);
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("Mas de una PetUIController en escena");
    }

    public void inicializar(int comida, int aburrimiento, int energia, int suciedad, 
        int ComidaTickRate, int AburrimientoTickRate, int EnergiaTickRate, int SuciedadTickRate) 
    {
        ultimaVezAlimentado = DateTime.Now;
        ultimaVezDormido = DateTime.Now;
        ultimaVezEntretenido = DateTime.Now;

        this.Comida = comida;
        this.Aburrimiento = aburrimiento;
        this.Energia = energia;
        this.Suciedad = suciedad;
        this.comidaTickRate = ComidaTickRate;
        this.aburrimientoTickRate = AburrimientoTickRate;
        this.energiaTickRate = EnergiaTickRate;
        this.suciedadTickRate = SuciedadTickRate;
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }

    private void Update() {
        if (ControladorTemporal.temporizadorInGame <= 0)
        {
            cambiarAburrimiento(-aburrimientoTickRate);
            cambiarComida(-comidaTickRate);
            cambiarEnergia(-energiaTickRate);
            cambiarSuciedad(-suciedadTickRate);
            if      (Suciedad < 33) { bien.SetActive(false); regular.SetActive(false); mal.SetActive(true); }
            else if (Suciedad >= 33 && Suciedad < 66) { bien.SetActive(false); regular.SetActive(true); mal.SetActive(false); }
            else { bien.SetActive(true); regular.SetActive(false); mal.SetActive(false); }
            PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
        }
    }

    public void cambiarComida(int n) 
    {
        Comida += n;

        if (n > 0)
        {
            ultimaVezAlimentado = DateTime.Now;
        }

        if (Comida < 0) //si no se cuida al bicho pasa algo
        {
            //comida
        }
        else if (Comida > 100) Comida = 100; //no sobrepasar el limite de comida
         else if (Comida < 0) Comida = 0;
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }
    public void cambiarAburrimiento(int n)
    {
        Aburrimiento += n;

        if (n > 0)
        {
            ultimaVezEntretenido = DateTime.Now;
        }

        if (Aburrimiento < 0) //si no se cuida al bicho pasa algo
        {
            //aburrimiento
        }
        else if (Aburrimiento > 100) Aburrimiento = 100; //no sobrepasar el limite de comida
        else if (Aburrimiento < 0) Aburrimiento = 0;
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }
    public void cambiarEnergia(int n)
    {
        Energia += n;

        if (n > 0)
        {
            ultimaVezDormido = DateTime.Now;
        }

        if (Energia < 0) //si no se cuida al bicho pasa algo
        {
            //cansancio
        }
        else if (Energia > 100) Energia = 100; //no sobrepasar el limite de comida
        else if (Energia < 0) Energia = 0;
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }
    public void cambiarSuciedad(int n)
    {
        Suciedad += n;

        if      (Suciedad < 33) { bien.SetActive(false); regular.SetActive(false); mal.SetActive(true); }
        else if (Suciedad >= 33 && Suciedad < 66) { bien.SetActive(false); regular.SetActive(true); mal.SetActive(false); }
        else { bien.SetActive(true); regular.SetActive(false); mal.SetActive(false);}
        if (Suciedad > 100) Suciedad = 100; //no sobrepasar el limite de comida
        else if (Suciedad < 0) Suciedad = 0;
    }
}
