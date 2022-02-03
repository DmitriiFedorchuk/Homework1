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

///Найти максимальное из трёх чисел.
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write("Самое большое число =");
Console.WriteLine(max);


/// Выяснить является ли число чётным
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if ( a% 2 == 0){
    Console.WriteLine("Данное число является чётным");
}
else Console.WriteLine("Данное число не является четным");



// Показать чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 1;
int ind = 0;
while (ind<=a)
{
    ind = ind+2;
    
    Console.WriteLine(ind);
}