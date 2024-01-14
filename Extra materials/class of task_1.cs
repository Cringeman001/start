/*
class Worker
{
    private string? name = "";
    private string? lastname = "";
    private int age = 0;
    private double weight = 0.0;

    public void get(string? n, string? ln, int a, double w)
    {
        this.name = n;
        this.lastname = ln;
        this.age = a;
        this.weight = w;
    }

    public void print()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Lastname: " + lastname);
        Console.WriteLine("Age: " + age + " years");
        Console.WriteLine("Weight: " + weight + " T");
    }
}
*/

class Sys_lib
{
    //passwords
    // -------------------------------------------------------
    private int Password_ad = 2222;
    private int Password_us = 1111;
    // -------------------------------------------------------

    // katalog
    // -------------------------------------------------------
    private string? name_1 = "Да, но нет, хотя да...";
    private double sale_1 = 49.99;
    private string? name_2 = "История слова ДА!";
    private double sale_2 = 999.99;
    // -------------------------------------------------------

    

    public void pass(string? name_user, int ent_password)
    {
        int n = 0;
        while(n == 0)
        {
            if (ent_password == this.Password_ad)
            {
                Console.WriteLine("Доступ разрешён.\n");
                n=1;
            }
            else if (ent_password == this.Password_us)
            {
                Console.WriteLine($"Добро пожаловать, пользователь {name_user}.");
                n=1;
            }
            else
            {
                Console.WriteLine("Доступ откланён.\nПопробуйте ещё раз.");
                n=1;
            }
        }
    }

    public void print_kat()
    {
        string? val_1 = $"1) Название: {this.name_1}\n   Цена: {this.sale_1}";
        string? val_2 = $"2) Название: {this.name_2}\n   Цена: {this.sale_2}";
        Console.WriteLine(val_1 + "\n" + val_2);
    }

    public int t = 0;
    void deal_check()
    {
        Console.WriteLine("Вас устраивает то, что вы выбрали?");
        Console.Write("Ваш ответ: ");
        string? answer = Console.ReadLine();
        if (answer == "yes" || answer == "да" || answer == "Yes" || answer == "Да")
        {
            Console.WriteLine("Заказ оформлен.");
            t = 1;
        }
        else
        {
            Console.WriteLine("Переоформление заказа...");
            t = 0;
        }
    }

    public void deal()
    {
        while (t==0)
        {
            Console.Write("Введите номер унтересующей вас книги: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine($"Вы заказали: \n{this.name_1} \nпо цене: {this.sale_1}");
                deal_check();
            }
            else if (num == 2)
            {
                Console.WriteLine($"Вы заказали: \n{this.name_2} \nпо цене: {this.sale_2}");
                deal_check();
            }
            else
            {
                Console.Write("Такой книги нет в нашем каталоге. Попробуйте ещё раз.");
            }
        }
    }
}
