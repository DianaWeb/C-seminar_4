//Найти сумму чисел от 1 д А
System.Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (A > 0)
{
	for (int i = 1; i <= A; i++)
	{
		sum = sum + i;
		//sum += i;
	}
	System.Console.WriteLine($"Сумма чисел от 1 до А = {sum}");
}
else
{
	System.Console.WriteLine("Вы ввели числ меньше нуля!");
}