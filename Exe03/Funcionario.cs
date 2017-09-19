using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe03 {
    class Funcionario {
        public string nome { get; set; }
        public int cpf { get; set; }
        public double salario { get; private set; }

        public void aumentarSalario(double porc) {
            salario += (salario * porc) / 100;
        }

        public Funcionario(int cpf, string nome, double salario) {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public override string ToString() {
            return "CPF: " + cpf + ", Nome: " + nome + ", Salario: R$ " + salario;

        }
    }
}
