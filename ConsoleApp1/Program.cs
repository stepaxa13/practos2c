void main()
{
    int x = 0;
    int vybor;
    do
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Игра 'Угадай число''");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Выход из программы");
        vybor = Convert.ToInt32(Console.ReadLine());
            if(vybor==1)
                ugaday(x);
            if(vybor==2)
                tablitsa();
            if(vybor==3)
                delitely(x);
    } while (vybor != 4);
}
void ugaday(int a)
{
    Random random = new Random();
    int x = random.Next(101);
    Console.WriteLine("Компьтер загадал число");
    while (true)
    {
        Console.WriteLine("Введите число");
        a = Convert.ToInt32(Console.ReadLine());
        if (x < a)
        {
            Console.WriteLine("Нужно число меньше");
        }
        if (x > a)
        {
            Console.WriteLine("Нужно число больше");
        }
        if (x == a)
        {
            Console.WriteLine("Вы победили!");
            break;
        }
    }
}
void tablitsa()
{
    int[,] tablitsa = new int[9, 9];
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            int A = i + 1;
            int B = j + 1;
            int C = A * B;
            tablitsa[i, j] = C;
        }
    }
    for (int j = 0; j < 9; j++)
    {
        for (int i = 0; i < 9; i++)
        {
            Console.Write(tablitsa[j, i]);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}
void delitely(int x)
{
    Console.WriteLine("Введите число");
    x = Convert.ToInt32(Console.ReadLine());
    for (int a = 1; a <= x; a++)
    {
        if (x % a == 0) Console.Write("{0} ", a);
    }
    Console.WriteLine();
}