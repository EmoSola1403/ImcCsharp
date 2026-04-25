double altura, peso, imc; 
Console.Write("Altura (m)...: \n"); 
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Peso(kg)...: \n"); 
peso = Convert.ToDouble(Console.ReadLine());

imc = peso / Math.Pow(altura, 2);

Console.WriteLine($"\nIMC: {imc:N1} kg/m²");
