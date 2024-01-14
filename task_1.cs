// task #5 of pdf list in telegram

Sys_lib use_lib = new Sys_lib();

Console.WriteLine("Здраствуйте!");
int s = 0;
Console.Write("Введите ваше имя: ");
string? name = Console.ReadLine();
while (s==0)
{
    Console.Write("Введите последние 4 цифры вашей карты: ");
    int card = Convert.ToInt32(Console.ReadLine());
    if (card >= 1000 && card <= 9999)
    {
        s = s + 1;
    }
}
Console.Write("Введите ваш пароль: ");
int ent_password = Convert.ToInt32(Console.ReadLine());

use_lib.pass(name, ent_password);
use_lib.print_kat();
use_lib.deal();
