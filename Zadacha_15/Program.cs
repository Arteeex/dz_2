Console.Clear();

Console.Write("Введите номер дня недели: ");
string a = Console.ReadLine();
switch(a)
{
    case "1":
    Console.WriteLine("Понедельник, рабочий день");
    break;
    
    case "2":
    Console.WriteLine("Вторник, рабочий день");
    break;

    case "3":
    Console.WriteLine("Среда, рабочий день");
    break;

    case "4":
    Console.WriteLine("Четверг, рабочий день");
    break;

    case "5":
    Console.WriteLine("Пятница, рабочий день");
    break;

    case "6":
    Console.WriteLine("Суббота, выходной день");
    break;

    case "7":
    Console.WriteLine("Воскресенье, выходной день");
    break;
}