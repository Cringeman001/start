/*
Console.Write("Enter first number: ");
int g = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter action: ");
string? operation = Console.ReadLine();

Console.Write("Enter second number: ");
int g1 = Convert.ToInt32(Console.ReadLine());

int c = 0;

if(operation == "+")
{
    c = g + g1;
}
else if(operation == "-")
{
    c = g - g1;
}
else if(operation == "*")
{
    c = g * g1;
}
else if(operation == "/")
{
    c = g / g1;
}
Console.WriteLine(" ");
Console.Write("Answer: ");
Console.WriteLine(c);
Console.WriteLine(" ");



Console.WriteLine(" ");

List<int> sp_fib = new List<int> {0};
int num1 = 0;
int num2 = 1;
int num10 = 0;
Console.Write("Enter number: ");
int how_many0 = Convert.ToInt32(Console.ReadLine());
int how_many1 = how_many0 - 1;

for (int i = 0; i < how_many1; i++)
{
    num10 = num2;
    Console.Write(num1 + ",");
    sp_fib.Add(num1);
    num2 = num1 + num2;
    num1 = num10;
}
Console.WriteLine(num1 + ".");
Console.WriteLine("What number are you interested in?");
int end_0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Answer: ");
if (end_0 <= how_many1)
{
    Console.WriteLine(sp_fib[end_0]); //num1 or sp_fib[end_0]
}
else if (end_0 > how_many1)
{
    Console.WriteLine("Not possible to show that number, because you don't mark him in line of Fibinachi's numbers.");
}
Console.WriteLine(" ");



Console.WriteLine(" ");
int end = 0;
Console.Write("Enter your amount: ");
int sum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount retention period(mounth): ");
int per = Convert.ToInt32(Console.ReadLine());

if(sum > 0 && per > 0)
{
    for (int i = 0; i < per; i++)
    {
        end = sum*7/100;
        sum = sum + end;
    }
    Console.WriteLine("You will get: " + sum);
}
else if(sum <= 0 || per <= 0)
{
    Console.WriteLine("You entered incorrect data. Please try again later.");
}
Console.WriteLine(" ");



List<int> list_of_num_2 = new List<int> { };
int ost = 0;
int cycle = 1;

Console.Write("Enter your number: ");
int num_10 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

for (int i = 0; i < cycle; i++)
{
    if (num_10 > 1)
    {
        Console.Write(num_10 + "   ");
        ost = num_10 % 2;
        num_10 = num_10 / 2;
        Console.WriteLine(ost);
        
        list_of_num_2.Add(ost);
        list_of_num_2.ForEach(Console.Write);
        Console.WriteLine(" ");
        cycle = cycle + 1;
    }
    else if (num_10 == 1)
    {
        Console.WriteLine("1   1");
        list_of_num_2.Add(1);
        list_of_num_2.ForEach(Console.Write);
        Console.WriteLine(" ");
    }
}
Console.WriteLine(" ");
list_of_num_2.ForEach(Console.WriteLine);
Console.WriteLine(" ");
list_of_num_2.Reverse();
list_of_num_2.ForEach(Console.Write);
Console.WriteLine(" ");



Console.Write("Введите количество чисел в вашем массиве: ");
int enter_kol = Convert.ToInt32(Console.ReadLine());
int num = 0;
int l = 1;
int one_two = 0;
int[] nums = new int[enter_kol];
int ost = enter_kol % 2;
if (ost == 1)
{
    one_two = enter_kol / 2 + 1;
}
else
{
    one_two = enter_kol / 2;
}

Console.WriteLine("Введите сами числа((число) и enter): ");
for (int i = 0; i < enter_kol; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    nums[i] = nums[i] + num;
}

Console.WriteLine("Вторая половина из данных вашего массива: ");
for (int i = 0; i < one_two; i++)
{
    Console.Write(nums[^l]);
    Console.Write(" ");
    l = l + 1;
}



// Линейный поиск

Console.Write("Введите количество чисел в вашем массиве: ");
int enter_kol = Convert.ToInt32(Console.ReadLine());
int num = 0;
int i1 = 1;
string? t_f = "False";
int[] nums = new int[enter_kol];

Console.WriteLine("Введите сами числа((число) + enter): ");
for (int i = 0; i < enter_kol; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    nums[i] = nums[i] + num;
}

Console.Write("Введите число, номер которого вас интересует: ");
int need = Convert.ToInt32(Console.ReadLine());

while (t_f=="False")
{
    try
    {
    if (nums[i1] == need)
        {
            t_f="True";
            Console.WriteLine("Номер вашего числа("+need+") в массиве - "+i1);
            i1 = i1+1;
            Console.WriteLine("Но для вас: номер вашего числа("+need+") - "+i1);
        }
        else
        {
            i1 = i1+1;
        }
    }
    catch (System.IndexOutOfRangeException)
    {
        Console.WriteLine("Такого числа нет в вашем массиве...");
        Console.WriteLine("Попробуйте ещё раз позже.");
        t_f="True";
    }
}



// Бинарный поиск

// Нужные начальные параметры и данные

Console.Write("Введите количество чисел в вашем массиве: ");
int enter_kol = Convert.ToInt32(Console.ReadLine()); // кол-во чисел в массиве
int num = 0; // номер числа в массиве
int temporary_value = 0; // временное значение номера массива
int low = 0; 
int high = enter_kol - 1;
int attempt_of_searching = 0; // попытка поиска нужного элемента
int trying = 0;
int[] nums = new int[enter_kol]; // пустой массив

// Ввод самого массива

Console.WriteLine("Введите сами числа((число) + enter): ");
for (int i = 0; i < enter_kol; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    nums[i] = nums[i] + num;
}

// Сортировка массива: от меньшего - к большему

Console.WriteLine("Ваш массив будет изменён.");
Console.Write("Ваш неизменённый массив: ");
for (int j = 0; j < enter_kol; j++)
{
    Console.Write(nums[j] + " ");
}

Console.WriteLine(" ");
Console.WriteLine("Подождите, идёт сортировка массива(от меньшего - к большему)...");

// Сама сортировка
for (int q = 0; q < nums.Length; q++)
{
    for (int s = q+1; s < nums.Length; s++)
    {
        if (nums[q] > nums[s])
        {
            temporary_value = nums[q];
            nums[q] = nums[s];
            nums[s] = temporary_value;
        }
    }
}


Console.Write("Ваш изменённый массив: ");
for (int l = 0; l < enter_kol; l++)
{
    Console.Write(nums[l] + " ");
}
Console.WriteLine(" ");

// Осуществление самого бинарного поиска
while (attempt_of_searching == 0)
{
    Console.Write("Введите число, номер которого вас интересует: ");
    int need = Convert.ToInt32(Console.ReadLine()); // нужный нам номер
    trying = 0;
    low = 0;
    high = enter_kol - 1;
    Console.WriteLine("Решение: ");
    while (trying == 0)
    {
        int mid = (high + low) / 2;
        Console.WriteLine(low + " + " + mid + " + " + high);
        if (mid == low && mid == high + 1 && low == high + 1 && need != nums[mid] || need < nums[0] || need > nums[enter_kol - 1])
        {
            trying = 1;
            Console.WriteLine("Такого числа нет в вашем массиве...");
            Console.WriteLine("Попробуйте ещё раз.");
        }
        else if (need == nums[mid] || mid == low && mid == high && low == high)
        {
            trying = 1;
            attempt_of_searching = 1;
            Console.WriteLine("Номер вашего числа(" + need + ") в массиве - " + mid);
            Console.WriteLine("Но для вас: номер вашего числа(" + need + ") - " + (mid + 1));
        }
        else if (need < nums[mid])
        {
            high = mid;
            Console.WriteLine(low + " + " + mid + " + " + high);
            Console.WriteLine("Далее...");
        }
        else if (need > nums[mid])
        {
            low = mid;
            Console.WriteLine(low + " + " + mid + " + " + high);
            Console.WriteLine("Далее...");
        }
        // int y = Convert.ToInt32(Console.ReadLine()); // для проверки каждого действия
    }
}



int fib(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return fib(n - 1) + fib(n - 2);
    }
}

Console.Write("Enter number: ");
int res_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Answer: " + fib(res_num-1));



Worker Loh = new Worker();

Console.Write("Enter your name: ");
string? name = Console.ReadLine();
Console.Write("Enter your lastname: ");
string? lastname = Console.ReadLine();
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your weight: ");
double weight = Convert.ToDouble(Console.ReadLine());

Loh.get(name, lastname, age, weight);
Console.WriteLine("Your data that has been saved in the system: ");
Loh.print();
Console.WriteLine("You have been hired!");



int akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return akk(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return akk(m - 1, akk(m, n - 1));
    }
    else
    {
        return 404;
    }
}

Console.Write("Enter first number: ");
int res_num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int res_num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Answer: " +akk(res_num_1, res_num_2));



// какой-то bruh походу
double N(double n)
{
    if (n >= 1)
    {
        double value = Math.Floor(N(n / 10));
        return value + N(N(n / 10) - value);
    }
    else
    {
        return n * 10;
    }
}

Console.Write("Enter number: ");
int res_num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Answer: " + Math.Round(N(res_num)));



int num(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return num(n-1) + n;
    }
}

Console.Write("Enter number: ");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Answer: " + num(h));
*/

// metanit