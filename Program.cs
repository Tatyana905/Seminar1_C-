/*написать  программу, к-рая возводит число в квадрат
например 4-> 16. -3 -> 9
*/

int number = Convert.ToInt32(Console.ReadLine());

//5^2 = 5*5

int square = number * number;

/*camelCase
double testResult = Math.Pow(number, 2); 
Pow - сокращение от power (число, степень) */

Console.WriteLine("Результат: " + square);
//конкатенация - к левой строчке приписывается правая