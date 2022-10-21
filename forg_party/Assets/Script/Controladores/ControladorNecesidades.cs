using UnityEngine;

public class ControladorNecesidades : MonoBehaviour
{
    public int Comida, Aburrimiento, Energia, Ira; //cantidad de los estats
    public int comidaTickRate, aburrimientoTickRate, energiaTickRate, iraTickRate; //cuanto cambiar los estats en cada una de sus actualizaciones

    public void inicializar(int comida, int aburrimiento, int energia, int ira) 
    {
        this.Comida = comida;
        this.Aburrimiento = aburrimiento;
        this.Energia = energia;
        this.Ira = ira;
    }
    
    private void Update() {
        if (ControladorTemporal.temporizadorInGame <= 0)
        {
            cambiarAburrimiento(-aburrimientoTickRate);
            cambiarComida(-comidaTickRate);
            cambiarEnergia(-energiaTickRate);
        }
        if (ControladorTemporal.temporizadorInGameIra <= 0)
            cambiarIra(-iraTickRate);
    }

    public void cambiarComida(int n) 
    {
        Comida += n;
        if (Comida < 0) //si no se cuida al bicho pasa algo
        {
            //comida
        }
        else if (Comida > 100) Comida = 100; //no sobrepasar el limite de comida
    }
    public void cambiarAburrimiento(int n)
    {
        Aburrimiento += n;
        if (Aburrimiento < 0) //si no se cuida al bicho pasa algo
        {
            //aburrimiento
        }
        else if (Aburrimiento > 100) Aburrimiento = 100; //no sobrepasar el limite de comida
    }
    public void cambiarEnergia(int n)
    {
        Energia += n;
        if (Energia < 0) //si no se cuida al bicho pasa algo
        {
            //cansancio
        }
        else if (Energia > 100) Energia = 100; //no sobrepasar el limite de comida
    }
    public void cambiarIra(int n)
    {
        Ira += n;
        if (Ira < 0) //si no se cuida al bicho pasa algo
        {
            //Modo Enfado
        }
        else if (Ira > 100) Ira = 100; //no sobrepasar el limite de comida
    }
}
