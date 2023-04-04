namespace Desafio
{
    internal class Solucao
    {


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
