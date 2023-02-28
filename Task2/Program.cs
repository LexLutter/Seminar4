Console.Write("Введите произвольное число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
 int result = 0;
while (FirstNumber / 10 > 0){
   
    FirstNumber = FirstNumber / 10;
    result++;
}
Console.WriteLine($"A в степени B равно: {result+1}.");