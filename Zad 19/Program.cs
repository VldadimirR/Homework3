// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ($"Введите пятизначное  число: ");
int number = Convert.ToInt32(Console.ReadLine());
int origin = number;
int revers = 0;
    while (number > 0)
  {
    int d = number % 10;
    revers = revers * 10 + d;
    number = number / 10;
  }
  if  (origin == revers)
  {
    Console.WriteLine($"{origin} это число палиндром");
  }
  else
  {
    Console.WriteLine($"{origin} это число не палиндром");
  }
