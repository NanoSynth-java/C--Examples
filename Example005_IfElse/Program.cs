Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();

if (username.ToLower() == "Даниил") {
    Console.WriteLine("Привет любимый!");
}

else {
    Console.Write("Привет ");
    Console.Write(username);
}