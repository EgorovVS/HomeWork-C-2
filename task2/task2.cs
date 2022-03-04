
Console.WriteLine("Программа для удаления второй цифры случайного трехзначного числа");

Random rnd = new Random();

int i = rnd.Next(100,1000);

Console.WriteLine(i);
string j = Convert.ToString(i);

j = j.Remove(1,1);

Console.WriteLine(j);