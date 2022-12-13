Console.Clear();
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int res = a % 2;

if (res != 0) {
    Console.WriteLine("Нет");
} else {
    Console.WriteLine("Да");
}
