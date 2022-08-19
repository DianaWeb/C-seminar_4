/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */
int enterNumbers()
{
	System.Console.Write("Введите число N: ");
	int N = Convert.ToInt32(Console.ReadLine());
	return N;
}

int multiplicationNumbers(int N)
{
	// System.Console.Write("Введите число N: ");
	// int N = Convert.ToInt32(Console.ReadLine());
	int res = 1;
	for (int i = 1; i <= N; i++)
	{
		res = res * i;
	}
	// System.Console.WriteLine($"Произведение чисел равно = {res}");
	return res;
}
int N = enterNumbers();
int result = multiplicationNumbers(N);
System.Console.WriteLine(result);