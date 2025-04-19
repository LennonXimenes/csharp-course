// Ex 01: Soma de dois inteiros
// Entrada: 10 30 | Saída: SOMA = 40

// Ex 02: Área do círculo
// Entrada: 2.00 | Saída: A=12.5664

// Ex 03: Diferença de produtos (A*B - C*D)
// Entrada: 5 6 7 8 | Saída: DIFERENCA = -26

// Ex 04: Cálculo de salário
// Entrada: 25 100 5.50 | Saída: SALARY = U$ 550.00

// Ex 05: Valor a pagar (peças)
// Entrada: 12 1 5.30 16 2 5.10 | Saída: VALOR A PAGAR: R$ 15.50

// Ex 06: Cálculo de áreas (triângulo, círculo, trapézio, quadrado, retângulo)
// Entrada: 3.0 4.0 5.2 | Saída: TRIANGULO: 7.800 CIRCULO: 84.949

using System.Collections.Generic;

namespace FourthProject
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      int y = 30;
      int xy = x + y;

      Console.WriteLine($"Saída: SOMA {xy}");

      List<double> radius = new List<double> { 2.00, 100.64, 15.00 };

      double pi = 3.14159;
      for (int i = 0; i < radius.Count; i++)
      {

        double area = pi * (radius[i] * radius[i]);
        Console.WriteLine($"Saída: Area {area:F4}");
      }
    }
  }
}