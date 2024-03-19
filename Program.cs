using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Switch/Case/Default
            //Console.Write("numero 1: ");
            //double n1 = double.Parse(Console.ReadLine());
            //Console.Write("Operação: ");
            //string op = Console.ReadLine();
            //Console.Write("numero 2: ");
            //double n2 = double.Parse(Console.ReadLine());
            //double r;
            //switch (op)
            //{
            //    case "+":
            //        r = n1+ n2;
            //        Console.WriteLine("resultado:" + r);
            //        break;
            //    case "-":
            //        r = n1 - n2;
            //        Console.WriteLine("resultado:" + r);
            //        break;
            //    case "*":
            //        r = n1 * n2;
            //        Console.WriteLine("resultado:" + r);
            //        break;
            //    case "/":
            //        r = n1 / n2;
            //        Console.WriteLine("resultado:" + r);
            //        break;
            //    default:
            //        Console.WriteLine("ERROR.Operação invalida");
            //        break;            
            //}
            //Console.ReadKey();
            //______________________________________________________________________________________
            //Console.Write("Forma: ");
            //string f = (Console.ReadLine());
            //double al;
            //double l;
            //double a;

            //switch (f)
            //{
            //    case "Q":
            //        Console.Write("Lado: ");
            //        l = double.Parse((Console.ReadLine()));
            //        a = l*l;
            //        Console.WriteLine("area:" + a);
            //        break;
            //    case "R":
            //        Console.Write("altura: ");
            //        al = double.Parse((Console.ReadLine()));
            //        Console.Write("largura: ");
            //        l = double.Parse((Console.ReadLine()));
            //        a = al * l;
            //        Console.WriteLine("area:" + a);
            //        break;
            //    case "T":
            //        Console.Write("altura: ");
            //        al = double.Parse((Console.ReadLine()));
            //        Console.Write("Base maior: ");
            //        double B = double.Parse((Console.ReadLine()));
            //        Console.Write("Base menor: ");
            //        double b = double.Parse((Console.ReadLine()));
            //        a = ((B+b)*al)/2;
            //        Console.WriteLine("area:" + a);
            //        break;
            //    case "L":
            //        Console.Write("Diâmetro maior: ");
            //        double D = double.Parse((Console.ReadLine()));
            //        Console.Write("Diâmetro maior: ");
            //        double d = double.Parse((Console.ReadLine()));
            //        a = (D * d)/2;
            //        Console.WriteLine("area:" + a);
            //        break;
            //    default:
            //        Console.WriteLine("ERROR.Forma invalida");
            //        break;
            //}
            //Console.ReadKey();
            //______________________________________________________________________________________

            Console.Write("Forma de Contratação: ");
            string Fc = (Console.ReadLine());
            double IRRF=0;
            double sl = 0;

            switch (Fc)
            {
                case "A":
                    Console.Write("Salário (bruto): ");
                    double sb = double.Parse((Console.ReadLine()));
                    double d = 200.00;
                    sl = sb - d;
                    break;
                case "C":
                    Console.Write("Quantidade de peças: ");
                    int Qp = int.Parse((Console.ReadLine()));
                    double vp = 10.5;
                    sl = Qp*vp;
                    break;
                case "H":
                    Console.Write("Quantidade de horas trabalhadas: ");
                    int Qh = int.Parse((Console.ReadLine()));
                    double Vh = 10.50;
                    sl = Vh*Qh;
                    break;
                default:
                    Console.WriteLine("ERROR.Forma invalida");
                    break;
            }

            if (sl <= 2000)
            {
                IRRF =sl * (7.5 / 100);
            }
            else if (sl <= 4000)
            {
                IRRF = sl * (12.0 / 100);
            }
            else
            {
                IRRF = sl * (15.0 / 100);
            }

            Console.WriteLine("valor de desconto do IRRF: " + IRRF);
            sl = sl - IRRF;
            Console.Write("valor do Salário Líquido: " + sl);
            Console.ReadKey();
        }
    }
}

