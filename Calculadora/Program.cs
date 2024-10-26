using System.Runtime.InteropServices;

class Program {
    public static void Main(string[] args)
    {
        char continuar = 's';
        while (continuar != 'n') {

            System.Console.WriteLine("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Qual a operacao? ");
            System.Console.WriteLine("1. Adicao");
            System.Console.WriteLine("2. Subtracao");
            System.Console.WriteLine("3. Multiplicacao");
            System.Console.WriteLine("4. Divisao");

            int operacao = int.Parse(Console.ReadLine());

            Calcular a = new Calcular(num1, num2);

            if(operacao == 1) {
                System.Console.WriteLine(a.Adicao());
            }
            else if(operacao == 2) {
                System.Console.WriteLine(a.Subtracao());
            }
            else if (operacao == 3) {
                System.Console.WriteLine(a.Multiplicacao());
            }
            else if (operacao == 4) {
                System.Console.WriteLine(a.Divisao());
            }     
        
        System.Console.WriteLine("Deseja fazer outra conta? ");
        continuar = char.Parse(Console.ReadLine());
        
    }
    }
}