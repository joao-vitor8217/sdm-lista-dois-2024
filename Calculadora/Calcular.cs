using System.Security.AccessControl;

class Calcular{
    public double Num1 { get; private set; }
    public double  Num2 { get; private set; }

    public Calcular(double num1, double num2)
    {
        Num1 = num1;
        Num2 = num2;
    }
    public double Adicao() {
        return Num1 + Num2;
    }
    public double Subtracao() {
        return Num1 - Num2;
    }
    public double Multiplicacao() {
        return Num1 * Num2;
    }
    public double Divisao() {
        return Num1 / Num2;
    }
}