// метод на введение трехзначного числа!!!
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

// написать программу, которая получает число А и находит сумму чисел до этого числа.
 int GetNumber()
 {
    int num = 0;
    while (num <=0) // цикл проверяет число на положительность, пока будет вводиться 
    // отрицательное, программа будет запрашивать ввести число заново. 
    {
       Console.WriteLine("Введите положительное число А: ");
       num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
 }
int GetSumm(int A)
{
    int summ = 0;
    for (int i = 1; i <= A; i++)
    {
       summ = summ + i;
    }
    return summ;
}
 int A = GetNumber();
 Console.WriteLine("Сумма чисел от 1 до " + A + " = " + GetSumm(A));

