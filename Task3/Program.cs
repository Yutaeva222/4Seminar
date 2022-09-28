int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetProizv(int number)
{
   int proizv = 1;
   for (int i = 1; i <= number ; i++)
   {
    proizv = proizv * i;
   }
   return proizv;
}
int number = GetNumber();
Console.WriteLine("Произведение чисел равно = " + GetProizv(number));