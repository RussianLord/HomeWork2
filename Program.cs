void Work1()
{
    Console.WriteLine("Задача 1: Программа создаёт случайное 3-х значное число и выводит вторую цифру этого числа");
    Console.WriteLine("Нажмите ENTER, чтобы активировать программу...");
    Console.ReadLine();
    int rnumber = new Random().Next(100, 1000);
    int rn1 = rnumber / 100;
    int rn2 = rnumber / 10 % 10;
    int rn3 = rnumber % 10;

    Console.WriteLine("Сгенерировано случайное число = " + rnumber + " и число = " + rn2 + " является его второй цифрой.");
}

void Work2()
{
    Console.WriteLine("Задача 2: Программа создаёт случайное число от 0 до 1000000 и выводит третью цифру этого числа, если число не трёхзначное, то выдаёт сообщение");
    Console.WriteLine("Нажмите ENTER, чтобы активировать программу...");
    Console.ReadLine();
    int rnumber = new Random().Next(0,1000000);
    
    if (rnumber<100)
    {
        Console.WriteLine($"Число {rnumber} не трёхзначное , поэтому третьей цифры нет");
    }
    else
    {
        string strnumber = rnumber.ToString();
        Console.WriteLine("Сгенерировано случайное число = " + rnumber + " и число = " + strnumber[2] + " является его третьей цифрой.");
    }


}

void Work3()
{
    Console.WriteLine("Задача 3: После ввода числа дня недели программа сообщит считается ли этот день выходным");
    Console.WriteLine("Введите число дня недели"); 
    int dnumber = Convert.ToInt32(Console.ReadLine());
    if (dnumber == 0 || dnumber >7)
    {
        Console.WriteLine("Число не является днём недели");
    }
    else if (dnumber < 6)
    {
        Console.WriteLine("Данный день недели у человечества считается рабочим");   
    }
    else
    {
        Console.WriteLine("Данный день недели у человечества считается выходным");
    }

}


// Work1();
// Work2();
// Work3();