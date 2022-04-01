// Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int power = 1;
for (int i = 1; i <= B; i++)
{
    power *= A;
}
Console.WriteLine(A + ", " + B + " --> " + power);