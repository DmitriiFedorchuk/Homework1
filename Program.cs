///Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = double.Parse(Console.ReadLine());
if (a>b){
    Console.Write("Самое большое число =");
    Console.WriteLine(a);
    Console.Write("Самое маленькое число=");
    Console.WriteLine(b);
}
else{
    Console.Write("Самое большое число =");
    Console.WriteLine(b);
    Console.Write("Самое маленькое число=");
    Console.WriteLine(a);
}
