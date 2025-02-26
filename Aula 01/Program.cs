namespace Aula_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 23;
            string nomeCompleto = "Sabrina Silva Queiroz";

            var variavelSemTipo = "Sabrina";

            Console.WriteLine(variavelSemTipo.GetType());

            Console.WriteLine("Digite o seu nome: ");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            string idadeUsuario = Console.ReadLine();




            Console.WriteLine($"Meu nome é {nomeUsuario} e a minha idade  é {idade} ");
        }
    }
}
