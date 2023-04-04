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

      
    }
}
