using System;
using System.Globalization;

namespace SalarioFuncionario {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem) {
            return SalarioBruto += (SalarioBruto * porcentagem / 100);
        }

        public override string ToString() {
            return Nome 
                + ", $ " 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
