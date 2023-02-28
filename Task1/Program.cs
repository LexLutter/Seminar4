Console.Write("Введите число A: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
var result = Math.Pow(FirstNumber, SecondNumber);
Console.WriteLine($"A в степени B равно: {result}.");