int N = 2;
int[] mas = new int[N];
int i = 0;
do
{
    Console.Write("Введите {0}-е число: ", (i + 1));
    mas[i] = int.Parse(Console.ReadLine());
    i++;
} while (i < N);
int t = 0, r = 0, z = 0;
foreach (int x in mas)
{
    if (x < 0)
        t++;
    else if (x > 0 && x != 0)
        r++;
    else  
    z++;
}
Console.WriteLine("Кол-во отрицательных : " + t + "\nКол-во положительных : " + r + "\nкол-во нулей: " + z );
Console.ReadKey();
