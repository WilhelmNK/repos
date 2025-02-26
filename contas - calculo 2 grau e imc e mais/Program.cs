using System;
using System.ComponentModel.Design;
using System.Xml;

int n;


do
{
    Console.Clear();
    Console.WriteLine("1 - Calculo equação 2 grau. ");
    Console.WriteLine("2 - Calculo IMC. ");
    Console.WriteLine("3 - Calculo de areas. ");
    Console.WriteLine("4 - Conversor de Temperatura(C~F). ");
    Console.WriteLine("5 - Verificar se número é primo. ");
    Console.WriteLine("6 - Sair. ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (n == 6)
        break;
    switch (n)
    {
        case 1:
            double n1;
            double n2;
            double n3;

            Console.Write("Digite o valor de a: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            double dlt = (n2 * n2) - (4 * n1 * n3);

            Console.WriteLine($"Delta: {dlt}");

            if (dlt < 0)
            {
                Console.WriteLine();
                Console.WriteLine("A equaçao nao possui raizes reais.");
            }
            else if (dlt == 0)
            {
                Console.WriteLine();
                double x = -n2 / (2 * n1);
                Console.WriteLine($"a equação possui uma raiz real: x = {x}");
            }
            else
            {
                Console.WriteLine();
                double x1 = (-n2 + Math.Sqrt(dlt)) / (2 * n1);
                double x2 = (-n2 - Math.Sqrt(dlt)) / (2 * n1);
                x1 = Math.Round(x1,4);
                x2 = Math.Round(x2,4);
                Console.WriteLine($"as raizes da equaçao sao: x1 = {x1} e x2 = {x2}");
            }
            Console.ReadKey();
            break;
        case 2:
            double a1;
            double a2;

            Console.Write("Digite o peso: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura: ");
            a2 = Convert.ToDouble(Console.ReadLine());

            double imc = a1 / (a2 * a2);

            imc = Math.Round(imc, 2);

            Console.WriteLine();
            Console.Write($"{imc} : ");
            
            if (imc < 18.5)
            {
                Console.WriteLine("baixo peso.");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("eutrofia (peso adequado).");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("sobrepeso.");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("obesidade Grau 1.");
            }
            else
            {
                Console.WriteLine("Obesidade(morbida).");
            }

            Console.ReadKey();
            break;

        case 3:
            int s;
            

            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triangulo");
            Console.WriteLine("3 - ciculo");
            Console.WriteLine("4 - voltar");
            s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {

                case 1:
                    double rq1;
                    double l1;

                    Console.WriteLine("");
                    Console.WriteLine("Digite o valor da lado: ");
                    l1 = Convert.ToDouble(Console.ReadLine());

                    rq1 = (l1 * l1);
                    rq1 = Math.Round(rq1, 4);
                    Console.WriteLine("");
                    Console.WriteLine($"a Area do quadrado e {rq1}");
                    Console.ReadKey();
                    break;
                case 2:
                    double rq2;
                    double b1;
                    double h1;

                    Console.WriteLine("");
                    Console.WriteLine("Digite o valor da base: ");
                    b1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o valor da altura: ");
                    h1 = Convert.ToDouble(Console.ReadLine());

                    rq2 = (b1 * h1) / 2;
                    rq2 = Math.Round(rq2, 4);
                    Console.WriteLine("");
                    Console.WriteLine($"a Area do Triangulo e {rq2}");
                    Console.ReadKey();
                    break;
                case 3:         
                    double ro1;
                    double rpo;

                    Console.Write("Digite o raio do círculo: ");
                    ro1 = Convert.ToDouble(Console.ReadLine());
                    rpo = Math.PI * ro1 * ro1;
                    rpo = Math.Round(rpo, 4);

                    Console.WriteLine("");
                    Console.WriteLine($"A área do círculo é {rpo}");
                    Console.ReadKey();
                    break;                    
            }
            break;
        case 4:
            double t1;
            Console.WriteLine("1 - C > F");
            Console.WriteLine("2 - F > C");
            t1 = Convert.ToDouble(Console.ReadLine());
            switch (t1)
            {
                case 1:
                    double c1;
                    double f1;
                    Console.Write("Escreva a temperatura(C) : ");
                    c1 = Convert.ToDouble(Console.ReadLine());

                    f1 = (c1 * 1.8 + 32);

                    Console.Write($"A temperatura em fahrenheit é {f1} ");
                    Console.ReadKey();
                    break;
                case 2:
                    double f2;
                    double c2;

                    Console.Write("Escreva a temperatura(F) : ");
                    f2 = Convert.ToDouble(Console.ReadLine());

                    c2 = (5/9*(f2-32));

                    Console.Write($"A temperatura em celsius é {c2} ");
                    Console.ReadKey();
                    break;

            }
            
             break;
        case 5:
            int np;
            int div = 0;
            Console.Write("Escreva o Numero : ");
            np = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= np; i++)
            {
                if (np % i == 0)
                    div++;
            }
            Console.WriteLine("");
            if (div == 2)
                Console.WriteLine("o Numero é Primo");
            else
                Console.WriteLine("o Numero Nao e Primo");
            Console.ReadKey();

            break;
        default:
            Console.WriteLine("escolha uma opção");
            Console.ReadKey();
            
            break;
    }
    
 
} while (true);