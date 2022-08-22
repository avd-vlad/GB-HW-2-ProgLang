/*----------------------------------------------------------------------------------------------------------------------
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
----------------------------------------------------------------------------------------------------------------------*/

bool CheckWeekEnd(int num)
{
    if(num==7^num==6)
        return true;
//    else
//        return false;
    return false;
}

string stDay;
int    intDay;

Console.WriteLine("Welcome to the \"Check WeekEnd\" Console App");
Console.Write("Please enter day's number or enter 'r' for random generation: ");

stDay = Console.ReadLine();
if(stDay.ToLower()=="r")
    intDay = new Random().Next(1,8);
else
    intDay = Convert.ToInt32(stDay);
if(CheckWeekEnd(intDay))
    Console.WriteLine($"Congrats! No work today! Day No {intDay} is a weekend!");
else
    Console.WriteLine($"Sorry, bro, keep working! Day No {intDay} is not a weekend yet");
