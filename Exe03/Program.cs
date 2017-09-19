using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe03 {
    class Program {
        static void Main(string[] args) {

            int opc, cpf, posCPF;
            List<Funcionario> func = new List<Funcionario>();

            Console.Write("Digite o n° de funcionarios: ");
            opc = int.Parse(Console.ReadLine());

            for (int i = 0; i < opc; i++) {

                Console.WriteLine("Digite o " + (i + int.Parse("1")).ToString() + "° funcionario.");
                do {
                    Console.Write("CPF: ");
                    cpf = int.Parse(Console.ReadLine());

                    posCPF = func.FindIndex(x => x.cpf == cpf);

                    if (posCPF > -1)
                        Console.WriteLine("CPF já existe, digite um novo CPF!");

                } while (posCPF > -1);

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                func.Add(new Funcionario(cpf, nome, salario));

            }


            Console.Write("CPF que receberá aumento: ");
            cpf = int.Parse(Console.ReadLine());
            posCPF = func.FindIndex(x => x.cpf == cpf);

            if (posCPF == -1)
                Console.WriteLine("CPF inexistente! ");
            else {
                Console.Write("Digite a % de aumento: ");
                double porc = double.Parse(Console.ReadLine());
                func[posCPF].aumentarSalario(porc);
            }

            for (int i = 0; i < opc; i++) {
                Console.WriteLine(func[i]);
            }

            Console.ReadLine();

        }
    }
}
