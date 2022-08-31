// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Console.Write("Введите A = ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите B = ");
//int b = Convert.ToInt32(Console.ReadLine());
//Double result = Math.Pow(a, b);
//Console.WriteLine("A в степени B = {0}", result);


int Method(int numberA, int numberB)
{
    int degNumber = numberA; for (int num = 2; num <= numberB; num++)
    {
        degNumber = degNumber * numberA;
    }
    return degNumber;
}
Console.Write("Введите число A = "); 
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = "); 
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("  A в степени B = {0} ", Method(numberA, numberB));
