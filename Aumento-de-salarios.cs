namespace Desafio
{
    internal class Solucao
    {

        public void AumentoDeSalario()
        {

            /*
                Desafio
                A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

 
                Salário	Percentual de Reajuste
                0 - 400.00
                400.01 - 800.00
                800.01 - 1200.00
                1200.01 - 2000.00
                Acima de 2000.00

                15%
                12%
                10%
                7%
                4%

                Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

                Entrada
                A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.

                Saída
                Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.


            */
            double salario = 0.00;
            double reajuste = 0.00;
            double novoSalario = 0.00;
            double percentual = 0.00;

            salario = Convert.ToDouble(Console.ReadLine());

            //TODO: Complete os espaços em branco com uma possível solução para o problema:

            if (salario < 0)
            {
                return;

            }
            else if (salario <= 400)
            {
                percentual = 15;
                reajuste = (115 * salario) / 100;
                novoSalario = reajuste;


            }
            else if (salario <= 800)
            {
                percentual = 12;
                reajuste = (112 * salario) / 100;
                novoSalario = reajuste;

            }
            else if (salario <= 1200)
            {
                percentual = 10;
                reajuste = (110 * salario) / 100;
                novoSalario = reajuste;

            }
            else if (salario <= 2000)
            {
                percentual = 7;
                reajuste = (107 * salario) / 100;
                novoSalario = reajuste;

            }
            else
            {
                percentual = 4;
                reajuste = (104 * salario) / 100;
                novoSalario = reajuste;

            }

            Console.WriteLine($"Novo salario: {reajuste.ToString("F")}");
            Console.WriteLine($"Reajuste ganho: {(reajuste - salario).ToString("F")}");
            Console.WriteLine($"Em percentual: {percentual} %");

        }

        public void EncaixaOuNao()
        {

            /*
                Desafios de Código Básico C# - Pottencial
                2 / 3 - Encaixa ou Não?

                Desafio
                Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

                Entrada
                A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.
             
             */

            //Adicionar using System; class Program, quando for fazer a entrega
 

            int qt = int.Parse(Console.ReadLine());
            // TODO: Crie as outras condições necessárias para a resolução do desafio:

            string[] v = new string[2];

            for (int i = 0; i < qt; ++i)
            {
                v = Console.ReadLine().Split(" ");
                string a = v[0];
                string b = v[1];

                if (b.Length > a.Length)
                    Console.WriteLine("nao encaixa");
                else if (a.EndsWith(b))
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("nao encaixa");


            }
        }

        public void DesafioTresDivisores()
        {
            /*
                Desafios de Código Básico C# - Pottencial
              
                Desafio
                Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 

                Entrada
                O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do desafio
         
             */


            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                // TODO: Crie as outras condições necessárias para a resolução do desafio:
                if (n % i == 0)
                {
                    count++;
                }
                if (count > i)
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(count == 3);


        }
    }
}
