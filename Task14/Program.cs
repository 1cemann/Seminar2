//**Задача 14:**
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//14  ->  нет
//46  ->  нет
//161 ->  да

using System;
using static System.Console;

Clear();

Write("type the first number ");
int number1 = Convert.ToInt32(ReadLine());

string answer = number1%7 == 0 && number1%23 == 0?"Yes":"No";
Write(answer);

