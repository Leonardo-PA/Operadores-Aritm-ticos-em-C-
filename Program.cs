using OperadoresAritmetricosC_.Models;

Calculadora calc = new Calculadora();

//Operações Basicas
calc.somar(10, 30);//esses valores representam nossos inteiros x,y que estão na pasta models Calculadora.cs
calc.subtracao(10, 50);
calc.multiplicao(15, 45);
calc.divisao(2, 2);

//potenciação 
calc.Potencia(3, 3);

//Trignometria
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);


//Incremento e decremento de numeros
int numeroIncremento  = 10;
 Console.WriteLine(numeroIncremento);
 
 Console.WriteLine("Incrementando o 10");
//numero = numero + 1; //pode ser usado esse metodo, caso precise de mais utilize esse metodo.
numeroIncremento++;//metodo de incremento, significa que é incremente ele em 1 

int numeroDecremento = 20; 
Console.WriteLine("Decremento o 20");
numeroDecremento --;//metodo de decremento, significa que estamos retirando um numero do nosso valor de inteiro declarado.

Console.WriteLine(numeroDecremento);

//Calculo de Raiz quadrada
calc.RaizQuadrade(9);
