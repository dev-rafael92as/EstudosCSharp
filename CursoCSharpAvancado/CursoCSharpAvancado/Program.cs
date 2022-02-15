// See https://aka.ms/new-console-template for more information
namespace CursoCSharpAvacado
{
    //class Carro
    //{
    //    public string Nome;
    //    public string Marca;
    //    public double Potencia;

    //    public Carro(string nome, string marca, double potencia)
    //    {
    //        Nome = nome;
    //        Marca = marca;
    //        Potencia = potencia;
    //    }
    //    public Carro()
    //    {
    //}
    //class Construtor
    //    {
    //        static void Main(string[] args)
    //        {
    //            var carro = new Carro();
    //            carro.Nome = "Hilux";
    //            carro.Marca = "Toyota";
    //            carro.Potencia = 3.1;
    //            Console.WriteLine($"{carro.Nome} {carro.Marca} {carro.Potencia}");

    //            var carro2 = new Carro("Celta", "Chevrolet", 1.0);

    //            Console.WriteLine($"{ carro2.Nome}  { carro2.Marca} {carro2.Potencia}");
    //        }
    //    }
    //}
    

    //class MetodosEstaticos
    //{
    //    public static int somar (int x, int y)
    //    {
    //        return x + y;
    //    }
    //    public static int multiplicar (int x, int y)
    //    {
    //        return x * y;
    //    }
    //    static void Main(string[] args)
    //    {
    //        var result = MetodosEstaticos.somar(3, 3);
    //        Console.WriteLine("A soma é igual a: {0}", result);

    //        Console.WriteLine(MetodosEstaticos.multiplicar(3, 4));
    //    }
    //}

    // Exemplo de Metodos estáticos sem o uso da determinação "static" do 
    // método multiplicar, é necessário a criação de uma instância

    //class MetodosEstaticos
    //{
    //    public static int somar(int x, int y)
    //    {
    //        return x + y;
    //    }
    //    public int multiplicar(int x, int y)
    //    {
    //        return x * y;
    //    }
    //    static void Main(string[] args)
    //    {
    //        var result = MetodosEstaticos.somar(3, 3);
    //        Console.WriteLine("A soma é igual a: {0}", result);

    //        MetodosEstaticos calc = new MetodosEstaticos();
    //        Console.WriteLine(calc.multiplicar(3, 4));
    //    }
    //}

/* Com a utilização de parâmetros variáveis é possível quantos parâmetros
 desejarmos e a linguagem complila-rá todos as variáveis, utilizando a função
 de linguagem "params" para dizer que teremos esse parâmetro. */

    //class ParametrosVariaveis
    //{
    //    public static void Despedida(params string[] alunos)
    //    {
    //        foreach (var aluno in alunos)
    //        {
    //            Console.WriteLine("Tchau {0}, até a próxima aula", aluno);
    //        }
    //    }
    //    static void Main()
    //    {
    //        Despedida("João", "Thiago", "Antonio", "Rafaela", "Marcos");
    //    }
    //}

    /* Método get e set */
    public class Carro
    {
        private string Marca;
        private string Nome;
        private double Potencia;

        public Carro(string marca, string nome, double potencia)
        {
            Marca = marca;
            Nome = nome;
            Potencia = potencia;
        }

        public Carro()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetNome()
        {
            return Nome;
        }

        static void Main(string[] args)
        {
            Carro carro = new Carro("Onix", "Chevrolet", 1.8);
            Console.WriteLine(carro.Potencia);
        }
    }
}

