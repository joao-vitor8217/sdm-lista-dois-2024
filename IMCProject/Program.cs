using IMCProject;

class Program{ 
    public static void Main(string[] args)
    {
        char continuar = 's';
        while (continuar != 'n') {

            System.Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            ImcCalcular a = new ImcCalcular(altura, peso);

            System.Console.WriteLine("Seu IMC e: " + a.CalcularImc().ToString("F1"));
            System.Console.WriteLine("Deseja fazer uma nova consulta? (s/n) ");
            continuar = char.Parse(Console.ReadLine());
        
       }
       
    }
}