
//task1
static double Function(double x)
{
    Random random = new Random();
    int a = random.Next(-50, 50);

    if (x == a)
    {
        throw new DivideByZeroException("Деление на ноль");
    }

    if (x < 0)
    {
        return x + Math.Pow(Math.Sin(1 / (x - a) + 4), 2);
    }

    else
    {
        return a * x / (Math.Sqrt(a * a - x * x));
    }
}

try
{
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine(Function(x));
}

catch (DivideByZeroException e)
{
    Console.WriteLine("Делить на ноль нельзя");
}

catch (FormatException e)
{
    Console.WriteLine("Некорректные данные");
}

catch (ArgumentException e)
{
    Console.WriteLine("Неккоректный аргумент");
}

//task2
static void InputArray(double[] arr, int k1, int k2)
{
    for (int i = k1; i <= k2; i++)
    {
        arr[i] = double.Parse(Console.ReadLine());
    }
}

static void FillRandom(double[] arr, int k1, int k2)
{
    Random random = new Random();
    for (int i = k1; i <= k2; i++)
    {
        arr[i] = random.NextDouble();
    }
}

//task3

try
{
    Console.WriteLine("Input k1: ");
    int k1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input k2: ");
    int k2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Input n: ");
    int n = int.Parse(Console.ReadLine());

    double[] x = new double[n];

    InputArray(x, k1, k2);
    FillRandom(x, k2, n);

    Console.WriteLine(x);

    double[] y = new double[n];
    for (int i = 0; i < n; i++)
    {
        y[i] = Function(x[i]);
    }

    Console.WriteLine(y);

    int count = 0;

    for (int i = 0; i < n; i++)
    {
        if (x[i] <= -4 && y[i] >= -4 && x[i] <= 0 && y[i] <= 4 && y[i] <= 4 - x[i])
        {
            count += 1;
            Console.WriteLine($"Точка {x[i]} ,{y[i]} попала");
        }
    }

    Console.WriteLine($"Общее количетсво точек {count}");

    //task4
    double length = 0;

    for (int i = 0; i < x.Length - 1; i++)
    {
        double dx = x[i + 1] - x[i];
        double dy = y[i + 1] - y[i];
        length += Math.Sqrt(dx * dx + dy * dy);
    }

    Console.WriteLine(length);

}

catch
{
    
}
