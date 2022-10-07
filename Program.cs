using Projeto02.Controllers;
using Projeto02.Entities;

namespace Projeto02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Aula 02 - C# WebDeveloper");

            //Instanciando a classe de controle
            var funcionarioController = new FuncionarioController();

            //Executando o método para cadastrar funcionário
            funcionarioController.CadastrarFuncionario();

            //Pausar o prompt
            Console.ReadKey();
        }
    }
}