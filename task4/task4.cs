
Console.WriteLine("Программа определения выходного дня");

Console.WriteLine("Введите номер дня недели");
int dayNum = Convert.ToInt32(Console.ReadLine());
if(dayNum>7){
    Console.WriteLine("В неделе 7 дней!!");
}
if(dayNum>5&dayNum<8){
Console.WriteLine("Да");
}
else {
Console.WriteLine("Нет");
}
   
    
