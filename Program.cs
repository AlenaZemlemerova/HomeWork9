void Exercice64(int firstNumber, int secondNumber)
{
    //Задача 64: Задайте значения M и N. Напишите программу, 
    //которая выведет все натуральные числа в промежутке от M до N
     if (firstNumber > secondNumber) return;
     Console.Write(firstNumber + " ");
     firstNumber++;
     Exercice64(firstNumber, secondNumber);
}

void Exercice66(int firstNumber, int secondNumber, int counter = 0)
{
    //Задача 66: Задайте значения M и N. Напишите программу, 
    //которая найдёт сумму натуральных элементов в промежутке от M до N.
    
     if (firstNumber > secondNumber) 
     {
        Console.Write(counter + " ");
        return;
     }     
     counter = counter + firstNumber;     
     firstNumber++;
     Exercice66(firstNumber, secondNumber, counter);
}

double Exercice68(double m, double n)
{
    //Задача 68: Напишите программу вычисления функции Аккермана 
    //с помощью рекурсии. Даны два неотрицательных числа m и n.

    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return Exercice68(m - 1, 1);
    else if (m > 0 && n > 0) return Exercice68(m - 1, Exercice68(m, n - 1));
    return Exercice68(m,n);
}

