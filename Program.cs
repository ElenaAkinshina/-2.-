//Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

//456->46
/*Console.WriteLine($"1. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа");
int number = new Random().Next(100, 1000);
int result = (number/100)*10+number%10;
Console.WriteLine($"{number} ->{result}");
Console.WriteLine($"{number} -> {number/100}{number%10}");*/


/*Console.WriteLine($"2 задача");
int num = new Random().Next(10, 100);
Console.WriteLine($"{num}");
int num1 = num/10;
int num2 = num%10;
if(num1 > num2) {
    Console.WriteLine($"Большая цифра {num1}");
}
else{
    Console.WriteLine($"Большая цифра {num2}");
}*/


/*Console.WriteLine($"3 задача");
Console.WriteLine("Введите число А: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int num_2 = int.Parse(Console.ReadLine()!);
if(num_1%num_2==0)
{
    Console.WriteLine($"Число {num_1} кратно числу {num_2}");
}
else{
    Console.WriteLine($"Число {num_1} и число {num_2} - НЕ кратные с остатком {num_1%num_2}");
}*/

//3я задача

/*Console.WriteLine($"Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if ((number % 7 == 0) && (number % 23 == 0)){
    Console.WriteLine($"Число {number} кратно 7 и 23 одновременно!");
}
else{
    Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно!");
}*/


//4 задача

/*Console.WriteLine($"Введите первое число: ");
int first_number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите первое число: ");
int second_number = int.Parse(Console.ReadLine()!);
if((first_number == Math.Pow(second_number, 2)) || (second_number == Math.Pow(first_number, 2))){
    if(first_number == Math.Pow(second_number, 2)){
        Console.WriteLine($"{first_number} является квадратом {second_number}");
    }
    if(second_number == Math.Pow(first_number, 2)){
        Console.WriteLine($"{second_number} является квадратом {first_number}");
    }
   
}
else{
    Console.WriteLine($"Числа не являются квадратом друг друга");
}*/