using System;
using System.Globalization;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplo 1

            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";
            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';
            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;
            //Console.WriteLine("Produtos:");
            //Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            //Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
            //Console.WriteLine();
            //Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            //Console.WriteLine();
            //Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            //Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            //Exemplo 2

            //int n1 = 3 + 4 * 2;
            //int n2 = (3 + 4) * 2;
            //int n3 = 17 % 3;
            //double n4 = 10.0 / 8.0;
            //double a = 1.0, b = -3.0, c = -4.0;
            //double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            //Exemplo 3

            //int a = 10;
            //Console.WriteLine(a);
            //a += 2;
            //Console.WriteLine(a);
            //a *= 3;
            //Console.WriteLine(a);
            //string s = "ABC";
            //Console.WriteLine(s);
            //s += "DEF";
            //Console.WriteLine(s);

            //Exemplo 4

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            //string[] v = Console.ReadLine().Split(' ');
            //string a = v[0];
            //string b = v[1];
            //string c = v[2];
            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //Exemplo 5


            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            //Console.WriteLine("Você digitou:");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            //Exemplo 6


            //Console.WriteLine("Entre com seu nome completo:");
            //string fullName = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //int bedrooms = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter product price:");
            //double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            //string[] vect = Console.ReadLine().Split(' ');
            //string lastName = vect[0];
            //int age = int.Parse(vect[1]);
            //double height = double.Parse(vect[2], CultureInfo.InvariantCulture);
            //Console.WriteLine(fullName);
            //Console.WriteLine(bedrooms);
            //Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(lastName);
            //Console.WriteLine(age);
            //Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));



            //https://github.com/acenelio/nivelamento-csharp/blob/master/uri1003/uri1003/Program.cs

            //int A, B, soma;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());

            //soma = A + B;

            //Console.WriteLine("SOMA = " + soma);

            //https://github.com/acenelio/nivelamento-csharp/blob/master/uri1003/uri1003/Program.cs

            //double R, A, pi = 3.14159;

            //R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //A = pi * R * R;

            //Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            //https://github.com/acenelio/nivelamento-csharp/blob/master/uri1007/uri1007/Program.cs

            //int A, B, C, D, dif;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());

            //dif = A * B - C * D;

            //Console.WriteLine("DIFERENCA = " + dif);

            //https://github.com/acenelio/nivelamento-csharp/blob/master/uri1008/uri1008/Program.cs

            //int numero, horas;
            //double valorHora, salario;

            //numero = int.Parse(Console.ReadLine());
            //horas = int.Parse(Console.ReadLine());
            //valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = valorHora * horas;

            //Console.WriteLine("NUMBER = " + numero);
            //Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            //https://github.com/acenelio/nivelamento-csharp/blob/master/uri1010/uri1010/Program.cs

            //int cod1, cod2, qte1, qte2;
            //double preco1, preco2, total;

            //string[] valores = Console.ReadLine().Split(' ');
            //cod1 = int.Parse(valores[0]);
            //qte1 = int.Parse(valores[1]);
            //preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //valores = Console.ReadLine().Split(' ');
            //cod2 = int.Parse(valores[0]);
            //qte2 = int.Parse(valores[1]);
            //preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = preco1 * qte1 + preco2 * qte2;

            //Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            //https://github.com/acenelio/nivelamento-csharp/blob/master/uri1012/uri1012/Program.cs

            //double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            //string[] valores = Console.ReadLine().Split(' ');
            //A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //triangulo = A * C / 2.0;
            //circulo = 3.14159 * C * C;
            //trapezio = (A + B) / 2.0 * C;
            //quadrado = B * B;
            //retangulo = A * B;

            //Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            //Exemplo de Operadores

            //int a = 10;
            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine("------------");
            //bool c5 = a <= 10;
            //bool c6 = a >= 10;
            //bool c7 = a == 10;
            //bool c8 = a != 10;
            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);

            //Exemplo de Operadores lógicos

            //bool c1 = 2 > 3 || 4 != 5; // true
            //bool c2 = !(2 > 3) && 4 != 5; // true
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine("--------------");
            //bool c3 = 10 < 5; // false
            //bool c4 = c1 || c2 && c3; // true
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);

            //Exemplo de estruturas condicionais

            //Console.WriteLine("Entre com um número inteiro:");
            //int x = int.Parse(Console.ReadLine());
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Par!");
            //}
            //else
            //{
            //    Console.WriteLine("Impar);
            //}

            //--------------------------------------------------


            //Console.WriteLine("Qual a hora atual?");
            //int hora = int.Parse(Console.ReadLine());
            //if (hora < 12)
            //{
            //    Console.WriteLine("Bom dia!");
            //}
            //else if (hora < 18)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite!");
            //}


            //Exemplo de escopo de variáveis

            //Modo Incorreto

            //double preco = double.Parse(Console.ReadLine());
            //if (preco > 100.0)
            //{
            //    double desconto = preco * 0.1;
            //}
            //Console.WriteLine(desconto);


            //Modo Correto

            //double preco = double.Parse(Console.ReadLine());
            //double desconto = 0.0;
            //if (preco > 100.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //Console.WriteLine(desconto);

            //Exercício 1 - https://github.com/acenelio/nivelamento-csharp/blob/master/cond01/cond01/Program.cs

            //int N = int.Parse(Console.ReadLine());

            //if (N < 0)
            //{
            //    Console.WriteLine("NEGATIVO");
            //}
            //else
            //{
            //    Console.WriteLine("NAO NEGATIVO");
            //}

            //Exercício 2 - https://github.com/acenelio/nivelamento-csharp/blob/master/cond02/cond02/Program.cs

            //int N = int.Parse(Console.ReadLine());

            //if (N % 2 == 0)
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("IMPAR");
            //}

            //Exercício 3 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1044/uri1044/Program.cs


            //string[] valores = Console.ReadLine().Split(' ');
            //int A = int.Parse(valores[0]);
            //int B = int.Parse(valores[1]);

            //if (A % B == 0 || B % A == 0)
            //{
            //    Console.WriteLine("Sao Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Nao sao Multiplos");
            //}

            //Exercício 4 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1046/uri1046/Program.cs

            //string[] valores = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(valores[0]);
            //int horaFinal = int.Parse(valores[1]);

            //int duracao;
            //if (horaInicial < horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal;
            //}

            //Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            //Exercício 5 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1038/uri1038/Program.cs

            //string[] valores = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(valores[0]);
            //int quantidade = int.Parse(valores[1]);

            //double total;
            //if (codigo == 1)
            //{
            //    total = quantidade * 4.0;
            //}
            //else if (codigo == 2)
            //{
            //    total = quantidade * 4.5;
            //}
            //else if (codigo == 3)
            //{
            //    total = quantidade * 5.0;
            //}
            //else if (codigo == 4)
            //{
            //    total = quantidade * 2.0;
            //}
            //else
            //{
            //    total = quantidade * 1.5;
            //}

            //Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 6 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1037/uri1037/Program.cs

            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (numero < 0.0 || numero > 100.0)
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}
            //else if (numero <= 25.0)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (numero <= 50.0)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (numero <= 75.0)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}

            //Exercício 7 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1041/uri1041/Program.cs

            //string[] valores = Console.ReadLine().Split(' ');
            //double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //if (x == 0.0 && y == 0.0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if (x == 0.0)
            //{
            //    Console.WriteLine("Eixo Y");
            //}
            //else if (y == 0.0)
            //{
            //    Console.WriteLine("Eixo X");
            //}
            //else if (x > 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else
            //{
            //    Console.WriteLine("Q4");
            //}


            //Exercício 8 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1051/uri1051/Program.cs

            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double imposto;
            //if (salario <= 2000.0)
            //{
            //    imposto = 0.0;
            //}
            //else if (salario <= 3000.0)
            //{
            //    imposto = (salario - 2000.0) * 0.08;
            //}
            //else if (salario <= 4500.0)
            //{
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //}
            //else
            //{
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //}

            //if (imposto == 0.0)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else
            //{
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}

            //FUNÇÕES

            //    Console.WriteLine("Digite três números:");
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    int n3 = int.Parse(Console.ReadLine());
            //    double resultado = Maior(n1, n2, n3);
            //    Console.WriteLine("Maior = " + resultado);
            //}
            //static int Maior(int a, int b, int c)
            //{
            //    int m;
            //    if (a > b && a > c)
            //    {
            //        m = a;
            //    }
            //    else if (b > c)
            //    {
            //        m = b;
            //    }
            //    else
            //    {
            //        m = c;
            //    }
            //    return m;
            //}

            //Estrutura de Repetição

            //Console.Write("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine("Número negativo!");


            //Exercício 1 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1114/uri1114/Program.cs


            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido");


            //Exercício 2 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1115/uri1115/Program.cs


            //string[] valores = Console.ReadLine().Split(' ');
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while (x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    valores = Console.ReadLine().Split(' ');
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);
            //}

            //Exercício 3 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1134/uri1134/Program.cs

            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;

            //int tipo = int.Parse(Console.ReadLine());

            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        alcool = alcool + 1;
            //    }
            //    else if (tipo == 2)
            //    {
            //        gasolina = gasolina + 1;
            //    }
            //    else if (tipo == 3)
            //    {
            //        diesel = diesel + 1;
            //    }

            //    tipo = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine("Alcool: " + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: " + diesel);


            //Estrutura de Repetição FOR

            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int N = int.Parse(Console.ReadLine());
            //int soma = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    Console.Write("Valor #{0}: ", i);
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}
            //Console.WriteLine("Soma = " + soma);

            //Exercício 1 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1067/uri1067/Program.cs


            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercício 2 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1072/uri1072/Program.cs

            //int n = int.Parse(Console.ReadLine());

            //int cont_in = 0;
            //int cont_out = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    if (x >= 10 && x <= 20)
            //    {
            //        cont_in = cont_in + 1;
            //    }
            //    else
            //    {
            //        cont_out = cont_out + 1;
            //    }
            //}

            //Console.WriteLine(cont_in + " in");
            //Console.WriteLine(cont_out + " out");

            //Exercício 3 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1079/uri1079/Program.cs

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{

            //    string[] line = Console.ReadLine().Split(' ');
            //    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            //    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            //    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}


            //Exercício 4 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1116/uri1116/Program.cs

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{

            //    string[] line = Console.ReadLine().Split(' ');
            //    int x = int.Parse(line[0]);
            //    int y = int.Parse(line[1]);

            //    if (y == 0)
            //    {
            //        Console.WriteLine("divisao impossivel");
            //    }
            //    else
            //    {
            //        double div = (double)x / y;
            //        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
            //    }
            //}


            //Exercício 5 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1153/uri1153/Program.cs

            //int n = int.Parse(Console.ReadLine());

            //int fat = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fat = fat * i;
            //}

            //Console.WriteLine(fat);

            //Exercício 6 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1157/uri1157/Program.cs

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercício 7 - https://github.com/acenelio/nivelamento-csharp/blob/master/uri1143/uri1143/Program.cs

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{

            //    int primeiro = i;
            //    int segundo = i * i;
            //    int terceiro = i * i * i;
            //    Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            //}




        }
    }
}
