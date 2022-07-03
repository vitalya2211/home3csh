using System;

namespace home3csh
{
    class Program
    {
		
		static void Main(string[] args)
        {
            static void Foo1(int a)
			{
				int temp = a, b = 0;
				while (temp != 0)
				{
					b = b * 10 + temp % 10;
					temp /= 10;
				}
				if (a == b)
					Console.WriteLine("palindrom\n");
				else Console.WriteLine("no :(\n");
			}
			double arrfoo(int[] array, int size)
			{
				double result;
				result = Math.Sqrt((array[0] - array[1]) * (array[0] - array[1]) + (array[2] - array[3]) * (array[2] - array[3]) + (array[4] - array[5]) * (array[4] - array[5]));
				return result;

			}
			void cubfun(int N)
			{
				for (int i = 0; i < N;)
				{
					i++;
					Console.WriteLine( i * i * i);
				}
			}
			/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            14212 -> нет
            12821 -> да
            23432 -> да
            Задача 21
            Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15.84
            A (7,-5, 0); B (1,-1,9) -> 11.53
            Задача 23
            Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125*/
			int num = 1, n = 0;
			const int size = 6;
			int[] array = new int[size];
			while (num!=0)
			{
				Console.Clear();
				Console.WriteLine ( "введите номер задачи. для выхода введите 0\n" +
					"1.проверка числа на палиндром\n" +
					"2.найти расстояние между двумя точками в трехмерной системе координат\n" +
					"3.вывести таблицу кубов до введенного числа N\n");
				num = Convert.ToInt32(Console.ReadLine());

				switch (num)
				{
					case 1:
						{
							Console.WriteLine("введите пятизначное число ");
							n = Convert.ToInt32(Console.ReadLine());

                           Foo1(n);
							Console.WriteLine("нажмите любую клавишу");
							Console.ReadKey();
						}
						break;
					case 2:
						{
							Console.WriteLine("введите координаты точек");
							Console.WriteLine("точка 1 X1 ");
							array[0]=Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("точка 1 Y1 ");
							array[2]=Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("точка 1 Z1 ");
							array[4] = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("точка 2 X2 ");
							array[1]=Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("точка 2 Y2 ");
							array[3] = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("точка 2 Z2 ");
							array[5]=Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("расстояние = " + arrfoo(array, size)) ;
							Console.WriteLine("нажмите любую клавишу");
							Console.ReadKey();
						}
						break;
					case 3:
						{
							Console.WriteLine("введите число (N)");
							n = Convert.ToInt32(Console.ReadLine());
							cubfun(n);
							Console.WriteLine("нажмите любую клавишу");
							Console.ReadKey();
						}
						break;
					case 0:
						{
							Console.WriteLine("goodbye!!!");
							System.Threading.Thread.Sleep(2000);
						}
						break;
					default:
						{
							Console.WriteLine("incorrect number task");
							Console.WriteLine("для продолжения нажмите любую клавишу");
							Console.ReadKey();
						}
						break;
				}
			}
		}
    }
}
