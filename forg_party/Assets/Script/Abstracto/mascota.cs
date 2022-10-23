using System;

public class mascota  
{
    public DateTime ultimaVezAlimentado, ultimaVezDormido, ultimaVezEntretenido, ultimaVezComplacido;
    public int Comida, Aburrimiento, Energia, Ira;

    public mascota(DateTime ultimaVezAlimentado, DateTime ultimaVezDormido, DateTime ultimaVezEntretenido, DateTime ultimaVezComplacido, int comida, int aburrimiento, int energia, int ira)
    {
        this.ultimaVezAlimentado = ultimaVezAlimentado;
        this.ultimaVezDormido = ultimaVezDormido;
        this.ultimaVezEntretenido = ultimaVezEntretenido;
        this.ultimaVezComplacido = ultimaVezComplacido;

        int Comida = comida;
        int Aburrimiento = aburrimiento;
        int Energia = energia;
        int Ira = ira;
    }
}
