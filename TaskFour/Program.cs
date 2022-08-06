
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите треть число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if( max< number2){ //Здесь можно сделать и через цикл while, но ради трех цифр не требуется думаю.)
    max = number2;
}
if(max< number3){
    max = number3;
}
System.Console.WriteLine("Наибольше число из трех = " + max);

    