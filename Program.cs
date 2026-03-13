string mes;
Console.WriteLine("Введите название страны: б, р, л");
string country = Console.ReadLine();
switch (country)
{
    case "б": mes = "Беларусь, Минск"; break;
    case "р": mes = "Россия, Москва"; break;
    case "л": mes = "Литва, Вильнюс"; break;
    default: mes = "Некорректная буква страны"; break;
}
Console.WriteLine(mes);
Console.ReadKey();