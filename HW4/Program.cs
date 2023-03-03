using System.ComponentModel;
using System;

//int type = 0, number = 0;
//string tmp;
//string num = "";
//try
//{
//    Console.WriteLine("Выберите способ перевода: 0-с десятичной в двойную, 1-с двойной в десятичную");
//    type = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите число: ");
//    tmp = Console.ReadLine();
//    switch (type)
//    {
//        case 0:
//            number = Convert.ToInt32(tmp);
//            for (int i = 0; number != 0; i++)
//            {
//                num+= Convert.ToInt32(number % 2);
//                number /= 2;
//            }
//            Console.WriteLine(num);
//            break;

//        case 1:
//            int tmp1 = 0, tmp2 = 0;
//            char[] chars = tmp.ToCharArray();
//            for (int i = 0; i < chars.Length; i++)
//            {
//                if (i == 0)
//                    number = chars[i]-'0';//нужно перенести в намбер содержимое ячейки а не код аски
//                else
//                {
//                    tmp2 = 2;
//                    tmp1 = chars[i] - '0';
//                    for (int j = 1; j < i; j++)
//                    {
//                        tmp2 *= 2;
//                    }
//                    tmp2 = tmp2 * tmp1;
//                    number += tmp2;
//                }
//            }
//            Console.WriteLine(number);

//            break;
//    }
//}
//catch (OverflowException)
//{
//    Console.WriteLine("осибька конвертации насяльника ");
//}
//catch (FormatException)
//{
//    Console.WriteLine("формат не тот насяльника ");
//}


//Task2
//Console.WriteLine("выберите текстом число от 0 до 9");
//string num = Console.ReadLine() ?? string.Empty;
//num = num.ToLower();
//if (num == "zero") Console.WriteLine(0);
//else if (num == "one")Console.WriteLine(1);
//else if (num == "two") Console.WriteLine(2);
//else if (num == "three") Console.WriteLine(3);
//else if (num == "four") Console.WriteLine(4);
//else if (num == "five") Console.WriteLine(5);
//else if (num == "six") Console.WriteLine(6);
//else if (num == "seven") Console.WriteLine(7);
//else if (num == "eight") Console.WriteLine(8);
//else if (num == "nine") Console.WriteLine(9);
//else Console.WriteLine("ошибка ввода ");

//Task3
//using HW4;
//try
//{
//    var a = new internationalPassport();
//    var b = new internationalPassport(466756789045, "Artemenko Sergay Adyardovich", new DateOnly(2022, 1, 1));
//    a.show();
//    b.show();
//}
//catch (FormatException)
//{
//    Console.WriteLine("формат не тот насяльника ");
//}

//Task4
Console.WriteLine("введите логическое уравнение");
string example = Console.ReadLine() ?? string.Empty;
char[] chars = example.ToCharArray();
int tmp1 = 0, tmp2 = 0;
bool d = false;
for (int i = 0;i < chars.Length; i++)
{
    if (Char.IsSymbol(chars[i]) && Char.IsSymbol(chars[i+1]))
    {
        for(int j = 0; j < i; j++)
        {
            tmp1+= chars[j] - '0';
        }
        for (int j = i+2; j < chars.Length; j++)
        {
            tmp2 += chars[j] - '0';
        }
        if (chars[i]== '<' && chars[i+1] == '=')
        {
            d = true ? tmp1 <= tmp2 : false;
        }
        else if (chars[i] == '>' && chars[i + 1] == '=')
        {
            d = true ? tmp1 >= tmp2 : false;
        }
        else if (chars[i] == '=' && chars[i + 1] == '=')
        {
            d = true ? tmp1 == tmp2 : false;
        }
        else if (chars[i] == '!' && chars[i + 1] == '=')
        {
            d = true ? tmp1 != tmp2 : false;
        }
    }
    else if(Char.IsSymbol(chars[i]))
    {
        for (int j = 0; j < i; j++)
        {
            tmp1 += chars[j] - '0';
        }
        for (int j = i + 1; j < chars.Length; j++)
        {
            tmp2 += chars[j] - '0';
        }
        if (chars[i] == '<')
        {
            d = true ? tmp1 < tmp2 : false;
        }
        else if (chars[i] == '>')
        {
            d = true ? tmp1 > tmp2 : false;
        }
    }
}
Console.WriteLine(d); // а как можно проще сделать? Можете расписать в тг или в майстат
