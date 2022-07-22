using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios_Lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; set; }


        public void AumentaSalario(double perc)
        {

            Salario = (Salario + (Salario*perc / 100));

        }

    }
}
