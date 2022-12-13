Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int res = 0;
while(res < a) {
    Console.Write(res + ", ");
    res = res + 2;
}
