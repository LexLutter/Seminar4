Console.Write("Введите произвольное число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
 int result = 0;
 int a = FirstNumber / 10;

while (FirstNumber / 10 > 0){
    result = FirstNumber % 10 + result;
    FirstNumber = FirstNumber / 10;
     //Console.WriteLine($"{FirstNumber % 10} ");
}
if (FirstNumber % 10 != 0) {
    result = FirstNumber % 10 + result;
    //Console.WriteLine($"{FirstNumber % 10} ");
}
Console.WriteLine($"Сумма цифр в числе равна: {result}.");