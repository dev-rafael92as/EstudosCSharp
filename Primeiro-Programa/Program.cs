namespace OlaMundo {
    class Program {    
            
        static void Main()
        {
            Console.WriteLine("Qual seu nome?");
            String nome = Console.ReadLine();
            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é {0} e sua idade é de {1}", nome, idade);
        }
    }
}
