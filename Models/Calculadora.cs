using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperadoresAritmetricosC_.Models
{
    public class Calculadora
    {

        //parte de operadores basicos
     public void somar(int x ,int y)//pedaço do codigo que vai ter uma função que realizar a operação.
     {
        Console.WriteLine($"{x} + {y} = {x + y}");
     }   
     public void subtracao(int x ,int y)
     {
        Console.WriteLine($"{x} - {y} = {x - y}");
     }   

      public void multiplicao(int x ,int y)
     {
        Console.WriteLine($"{x} * {y} = {x * y}");
     } 
      public void divisao(int x ,int y)
     {
        Console.WriteLine($"{x} / {y} = {x / y}");
     } 

        //Parte de potencias 
     public void Potencia(int x, int y)
     {
        double pot = Math.Pow(x,y);
        Console.WriteLine($"{x}^{y} = {pot}");
     }

        //Parte de trignometria
    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
    }
    public void Coseno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double coseno = Math.Cos(radiano);
        Console.WriteLine($"Seno de {angulo}° = {Math.Round(coseno, 4)}");
    }
    public void Tangente(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double tangente = Math.Tan(radiano);
        Console.WriteLine($"Seno de {angulo}° = {Math.Round(tangente, 4)}");
    }

        //Parte de Raiz quadrada

    public void  RaizQuadrade(double x)
    {
        double raiz = Math.Sqrt(x);
        Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
    }

    }
}