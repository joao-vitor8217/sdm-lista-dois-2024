using System;

namespace IMCProject;

public class ImcCalcular
{
    public double Altura { get; set; }
    public double Peso { get; set; }

    public ImcCalcular(double altura, double peso)
    {
        Altura = altura;
        Peso = peso;
        
    }
    public double CalcularImc() {
        return Peso / (Altura * Altura);
    }

}
