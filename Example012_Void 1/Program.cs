// Вид 1

using System.Data;

void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1();

//Вид 2
void Method2(string message)
{
    Console.WriteLine(message);
}
Method2(message: "Текст сообщения");

void Method2(string message, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(message);
        i++;
    }
}
Method2(count: 4, message: "новый текст");

//ВИД 3 

int Method3();
{
    return DataTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4 
/*
 * 
 * string Method4(int count, char c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "qwerrty");
Console.WriteLine(res); 
*/


string Method4(int count, char c)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "qwerrty");
Console.WriteLine(res);


// ТАБЛИЦА УМНОЖЕНИЯ 

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
 }
