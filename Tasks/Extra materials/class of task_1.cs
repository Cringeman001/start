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

class Lib(int ent_password, int n)
{
    int n = 0;
    Console.WriteLine("Здраствуйте, ********. Пожалуйста введите пароль, в целях безопасности.");
    Console.Write("Пароль: ");
    int Password_ad = 2222;
    int Password_us = 1111;
    while(n == 0)
    {
        if (ent_password == Password_ad)
        {
            Console.WriteLine("Доступ разрешён.\n");
            n+=1;
        }
        else if (ent_password == Password_us)
        {
            Console.WriteLine("Здраствуйте, пользователь ********.\n");
            n+=1;
        }
        else
        {
            Console.WriteLine("Доступ откланён.\nПопробуйте ещё раз или перезапустите программу.");
        }
    }
}
