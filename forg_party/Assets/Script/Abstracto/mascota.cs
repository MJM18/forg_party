using System;

public class mascota  
{
    public DateTime ultimaVezAlimentado, ultimaVezDormido, ultimaVezEntretenido, ultimaVezCalmado;
    public int Comida, Aburrimiento, Energia, Ira;

    public mascota(DateTime UltimaVezAlimentado, DateTime UltimaVezDormido, DateTime UltimaVezEntretenido, DateTime UltimaVezCalmado, int comida, int aburrimiento, int energia, int ira)
    {
        this.ultimaVezAlimentado = UltimaVezAlimentado;
        this.ultimaVezDormido = UltimaVezDormido;
        this.ultimaVezEntretenido = UltimaVezEntretenido;
        this.ultimaVezCalmado = UltimaVezCalmado;

        int Comida = comida;
        int Aburrimiento = aburrimiento;
        int Energia = energia;
        int Ira = ira;
    }
}
