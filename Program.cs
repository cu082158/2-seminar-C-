/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


/* int number = new Random().Next (100, 999);
Console.WriteLine (number);
int firstNumber = number; 
string secondNumber = Convert.ToString(firstNumber);
Console.WriteLine(secondNumber[1]); */


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6  */


/* Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра - " + numberText[2]);
}
else {
  Console.WriteLine("- третьей цифры нет");
}
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

/* Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("этот день выходной ");
  }
  else 
  if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("это вообще не день недели");
  }
  else 
  Console.WriteLine("этот день не выходной ");
}

CheckingTheDayOfTheWeek(dayNumber);
*/
