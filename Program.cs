//Задача 10:  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

Console.Clear();
  
Console.Write("Введите трехзначное число: ");
int threeDigit = Convert.ToInt32(Console.ReadLine());
string digitNumber = Convert.ToString(threeDigit);

Console.WriteLine(digitNumber[1]);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

Console.Clear();

Console.Write("Введите число: ");
int abc = Convert.ToInt32(Console.ReadLine());
string abcString = Convert.ToString(abc);

    if (abcString.Length > 2)
        {
      Console.WriteLine("Третья цифра = " + abcString[2]);
        }
    else 
        {
      Console.WriteLine("третьей цифры нет");
        }
        */

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*

Console.Clear();

Console.Write("Введите номер дня недели от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

DayWeek(dayNumber);

void DayWeek (int dayNumber) 
    {
        if (dayNumber == 6 || dayNumber == 7) {
        Console.WriteLine("выходной");
            }
                else if (dayNumber < 1 || dayNumber > 7) {
                 Console.WriteLine("в неделе от 1 до 7 дней");
             }
                 else Console.WriteLine("будний");
    }
*/