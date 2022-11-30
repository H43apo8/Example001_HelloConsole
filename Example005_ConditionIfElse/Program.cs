Console.Write("Введите имя пользователя: ");
string Username = Console.ReadLine();

    if(Username.ToLower() == "красавчик")
    {
        Console.WriteLine("Еб@ть ты Красавчик!");
    }
    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(Username);
    }