using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vendedor = new string[5];
            double[] venda = new double[5];
            double[] comissao = new double[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Informe o vendedor: ");
                vendedor[i] = Console.ReadLine();
                Console.WriteLine("Informe o valor da sua venda: ");
                venda[i] = double.Parse(Console.ReadLine());

                if (venda[i] <= 20000) comissao[i] = venda[i] * 0.05;
                else if (venda[i] <= 40000) comissao[i] = venda[i] * 0.06;
                else comissao[i] = venda[i] * 0.07;
            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("Vendedor: " + vendedor[j] +
                    " Valor da venda: " + venda[j].ToString("C") +
                    " Valor da comissão: " + comissao[j].ToString("C")) ;
            }
            Console.ReadKey();
        }
    }
}
