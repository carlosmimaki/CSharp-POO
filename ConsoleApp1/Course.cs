using System;
using System.Globalization;

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



        }
    }
}
