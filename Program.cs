/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

// Console.Write("Введите кол-во чисел, которое надо проверить: ");
// int num = int.Parse(Console.ReadLine()!);
// int count = 0;
// for (int i = 0; i < num; i++){
//     Console.Write($"Введите число {i+1}: ");
//     int x = int.Parse(Console.ReadLine()!);
//     if(x > 0){
//         count ++;
//     }
// }
// Console.WriteLine($"Введено {count} чисел больше 0");

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

// Console.Write("Введите b1: ");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите k1: ");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите b2: ");
// double b2 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите k2: ");
// double k2 = double.Parse(Console.ReadLine()!);
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * (b2 - b1) / (k1 - k2) + b1;
// Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");

/* Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)
Найти произведение всех элементов массива целых чисел, меньших заданного числа. 
Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100. */

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int[] array = GetArray(10, 50, 100);
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine($"Произведение всех элементов массива, которые меньше {number}, равно {MathResult(array, number)}");

// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }

// int MathResult(int[] array, int number){
//     int result = 1;
//     for (int i = 0; i < array.Length; i++){
//         if(array[i] < number){
//             result = result * array[i];
//         }
//     }
//     return result;
// }