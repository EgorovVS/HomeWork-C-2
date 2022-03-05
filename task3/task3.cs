
Console.WriteLine("Программа вывода третьей цифры заданного числа");

Console.WriteLine("Введите число");

string i = Convert.ToString(Console.ReadLine());

if(i.Length>2){
Console.WriteLine(i[2] + " - третья цифра заданного числа");
} else { Console.WriteLine("Третьей цифры нет");}