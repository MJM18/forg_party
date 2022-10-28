using UnityEngine;

public class ControladorNecesidades : MonoBehaviour
{
    public int Comida, Aburrimiento , Energia ; //cantidad de los estats
    public int comidaTickRate, aburrimientoTickRate, energiaTickRate; //cuanto cambiar los estats en cada una de sus actualizaciones
    public static ControladorNecesidades instance;
    private void Awake()
    {
        inicializar(100, 100, 100 ,10 , 10, 10);
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("Mas de una PetUIController en escena");
    }

    public void inicializar(int comida, int aburrimiento, int energia, 
        int ComidaTickRate, int AburrimientoTickRate, int EnergiaTickRate) 
    {
        this.Comida = comida;
        this.Aburrimiento = aburrimiento;
        this.Energia = energia;  
        this.comidaTickRate = ComidaTickRate;
        this.aburrimientoTickRate = AburrimientoTickRate;
        this.energiaTickRate = EnergiaTickRate;
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }

    private void Update() {
        if (ControladorTemporal.temporizadorInGame <= 0)
        {
            cambiarAburrimiento(-aburrimientoTickRate);
            cambiarComida(-comidaTickRate);
            cambiarEnergia(-energiaTickRate);
            PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
        }
    }

    public void cambiarComida(int n) 
    {
        Comida += n;
        if (Comida < 0) //si no se cuida al bicho pasa algo
        {
            //comida
        }
        else if (Comida > 100) Comida = 100; //no sobrepasar el limite de comida
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }
    public void cambiarAburrimiento(int n)
    {
        Aburrimiento += n;
        if (Aburrimiento < 0) //si no se cuida al bicho pasa algo
        {
            //aburrimiento
        }
        else if (Aburrimiento > 100) Aburrimiento = 100; //no sobrepasar el limite de comida
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }
    public void cambiarEnergia(int n)
    {
        Energia += n;
        if (Energia < 0) //si no se cuida al bicho pasa algo
        {
            //cansancio
        }
        else if (Energia > 100) Energia = 100; //no sobrepasar el limite de comida
        PetUIcontroller.instance.UpdateImagenes(Comida, Aburrimiento, Energia);
    }

}
