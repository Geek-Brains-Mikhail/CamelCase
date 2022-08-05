
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int score = 2;
if(number > 1){
    while(score<=number){
        if(score%2==0){
            Console.WriteLine(score);
            
        }
        score++;
    }
}
else{
    score=0;
    while(score>= number){
        if(score%2 == 0){
            Console.WriteLine(score);
        }
        score--;
    }
}