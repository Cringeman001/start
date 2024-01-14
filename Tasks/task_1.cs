// task #5 of pdf list in telegram

string? Kat(int n)
{
    Console.Write("Введите название вашего аккаунта: ");
    string? name_user = Console.ReadLine();
    Console.Write("Введите последние 4 цифры вашей карты: ");
    int card = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ваш пароль: ");
    int ent_password = Convert.ToInt32(Console.ReadLine());
    Lib(p, 0);

    string? name_1 = "Да, но нет, хотя да...";
    double sale_1 = 49.99;
    string? val_1 = $"1) Название: {name_1}\n   Цена: {sale_1}";
    string? name_2 = "История слова ДА!";
    double sale_2 = 999.99;
    string? val_2 = $"2) Название: {name_2}\n   Цена: {sale_2}";
    Console.WriteLine(val_1 + "\n" + val_2);
    
    while (n==0)
    {
        Console.Write("Введите номер унтересующей вас книги: ");
        int ant = Convert.ToInt32(Console.ReadLine());

        if(ant <= 2)
        {
            n+=1;
        }
        else
        {
            Console.Write("Такой книги нет в нашем каталоге. Попробуйте ещё раз.");
        }
    }
    return $"Вы заказали: \nДА \nпо цене: ДА \nпо карте: ДА"
}



Console.WriteLine("Здраствуйте, ********! \nКакая книга вас интересует? \n(В ответе укажите номер книги)");
Console.WriteLine(Kat(0));
