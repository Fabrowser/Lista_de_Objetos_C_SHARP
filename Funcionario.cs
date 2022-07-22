using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios_Lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }


        public void AumentaSalario(double perc)
        {

            Salario = (Salario + (Salario*perc / 100));

        }

    }
}
