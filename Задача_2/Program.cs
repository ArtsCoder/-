// 1.на вход принимает два числа 
// 2. проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
int number = number2*number2;
if (number1==number) 
 {
     Console.WriteLine("YES");
 }
 else
 {
   Console.WriteLine("NO");
 } 
 

//Console.WriteLine("Число 1 является Квадртом числа 2); 