using System;

public class Mascota  
{
    public DateTime ultimaVezAlimentado, ultimaVezDormido, ultimaVezEntretenido;
    public int Comida, Aburrimiento, Energia;

    public Mascota(DateTime UltimaVezAlimentado, DateTime UltimaVezDormido, DateTime UltimaVezEntretenido, int comida, int aburrimiento, int energia)
    {
        this.ultimaVezAlimentado = UltimaVezAlimentado;
        this.ultimaVezDormido = UltimaVezDormido;
        this.ultimaVezEntretenido = UltimaVezEntretenido;

        int Comida = comida;
        int Aburrimiento = aburrimiento;
        int Energia = energia;
    }

}
