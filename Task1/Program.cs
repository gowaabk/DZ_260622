/* Задача 1

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int number = Prompt("Введите 5-тизначное число => ");

if (number >= 10000 && number <= 99999) // Проверка правильности ввода
{
    int indexBegin = (int)Math.Log10(number) + 1; //Получение количества цифр в числе.

    int priznakP = 0; //Признак палиндрома 0 нет , 1 да
    int indexReverse = 0; // индекс для перебора числа в обратном порядке
    while (indexBegin > 0)      // перебор и сравнение числа по цифрам
    {
        int firstPart = (number / (int)Math.Pow(10, indexReverse)) % 10; //отсекаем по правой части
        int secondPart = (number / (int)Math.Pow(10, indexBegin - 1)) % 10; // отсекаем по левой части
        if (firstPart != secondPart) //Проверяем если числа правой и левой части не равны то ставим признак и выходим
        {
            priznakP = 1;
            break;
        }
        indexBegin--; // Идем -> по числу
        indexReverse++; //Идем <- по числу
    }
    if (priznakP == 1) // Признак = 1 то плаиндром иначе нет 
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
    else System.Console.WriteLine($"Число {number} является палиндромом");
}
else System.Console.WriteLine($"Число {number} не является пятизначным");

