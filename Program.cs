using System;
using System.Collections.Generic;

namespace Funcionarios_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Funcionários deseja Registrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionario = new List<Funcionario>();



            //Cadastra Funcionários
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Digite o ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o Salário: ");
                double salario = double.Parse(Console.ReadLine());

                funcionario.Add(new Funcionario(id, nome, salario));
            }
            Console.WriteLine("\nFuncionários: -------------");
            Console.WriteLine("---------------------------");




            //Exibe todos os funcionários
            foreach (Funcionario func in funcionario)
            {

                Console.WriteLine("Id: " + func.Id + "\nNome: " + func.Nome + "\nSalario: " +
                     func.Salario);
                Console.WriteLine("---------------------------");
            }


            Console.WriteLine("Entre com o Codigo do empregado para aumentar o salário:");
            int cd_aumento = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o percentual para aumentar o salário:");
            double percentual_aumento = double.Parse(Console.ReadLine());


            foreach (Funcionario func in funcionario)
            {

                if (func.Id == cd_aumento)
                {
                    func.AumentaSalario(percentual_aumento);
                }
            }

            Console.WriteLine("\nFuncionários: -------------");
            Console.WriteLine("---------------------------");
            //Exibe todos os funcionários com Salario atualizado
            foreach (Funcionario func in funcionario)
            {

                Console.WriteLine("Id: " + func.Id + "\nNome: " + func.Nome + "\nSalario: " +
                     func.Salario);
                Console.WriteLine("---------------------------");
            }

        }
    }
}
