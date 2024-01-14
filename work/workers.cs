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