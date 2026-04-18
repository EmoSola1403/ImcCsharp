Console.WriteLine(" Calculadora de Soma Simples, Clique para continuar... ");
Console.ReadKey();

Console.Write("Digite o Primeiro número ");
// lê a entrade e converte para o numero decimal (double)
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número ");
double num2 = Convert.ToDouble(Console.ReadLine());

double resultado = num1 + num2;

Console.WriteLine("=============================================");
Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");

