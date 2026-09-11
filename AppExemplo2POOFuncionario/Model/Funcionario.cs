using System;
using System.Collections.Generic;
using System.Text;

namespace AppExemplo2POOFuncionario.Model
{
    public class Funcionario
    {
        public string nome;
        public int idade;
        public string sexo;
        public double salario;

        public double CalcularDecimoTerceiro(Int32 mesesTrabalhados)
        {
            double decimoTerceiro;
            decimoTerceiro = salario*mesesTrabalhados / 12;
            return Math.Round(decimoTerceiro,2);
        }

        public void CalcularFerias()
        {
            double ferias;
            ferias = salario + salario / 3;
            Console.WriteLine($"As férais desse funcionário é R${Math.Round(ferias,2)}");
        }
    }
}
