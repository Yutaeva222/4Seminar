// Метод на введение трехзначного числа!!!
// int GetNumberThreeDigit()
// {
//     int num = 0;
//     while (num < 99 || num > 1000)
//     {
//         Console.WriteLine("Введите трехзначное число: ");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
//     return num;
// }
// int a = GetNumberThreeDigit();
// Console.WriteLine(a);




// Написать программу, которая получает число А и находит сумму чисел до этого числа.
//  int GetNumber()
//  {
//     int num = 0;
//     while (num <=0) // цикл проверяет число на положительность, пока будет вводиться 
//     // отрицательное, программа будет запрашивать ввести число заново. 
//     {
//        Console.WriteLine("Введите положительное число А: ");
//        num = Convert.ToInt32(Console.ReadLine());
//     }
//     return num;
//  }
// int GetSumm(int A)
// {
//     int summ = 0;
//     for (int i = 1; i <= A; i++)
//     {
//        summ = summ + i;
//     }
//     return summ;
// }
//  int A = GetNumber();
//  Console.WriteLine("Сумма чисел от 1 до " + A + " = " + GetSumm(A));




// Программа, которая на вход получает число, и, определяет и выводит число цифр в нем.
Console.Clear();
int GetNumber()
{
    Console.WriteLine("Введите любое число : ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetDigCount(int Number) // метод определения кол-ва цифр в числе.
{
    int DigCount = 0;
    while (Math.Abs(Number) > 0)
    {
        Number = Number / 10;
        DigCount ++;
    }
    return DigCount;
}
Console.WriteLine("Количество цифр в числе " + GetDigCount(GetNumber()));