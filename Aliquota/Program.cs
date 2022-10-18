using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o seu salário: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        if (salario >= 1900 && salario <= 2800)
        {
            Console.WriteLine("O IR é de 7.5%, podendo deduzir na declaração o valor de R$ 142");
        }
        else if (salario >= 2800 && salario <= 3751)
        {
            Console.WriteLine("O IR é de 15%, podendo deduzir na declaração o valor de R$ 350");
        }
        else if (salario >= 3751 && salario <= 4664)
        {
            Console.WriteLine("O IR é de 22.5%, podendo deduzir na declaração o valor de R$ 636");
        }
        else
        {
            Console.WriteLine("Procure um contador para maiores orientações!");
        }
    }
}