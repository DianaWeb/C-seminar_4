/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */
System.Console.Write("Введите ччисло: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (num > 0)
{
	num = num / 10;
	count++;
}
System.Console.WriteLine(count);