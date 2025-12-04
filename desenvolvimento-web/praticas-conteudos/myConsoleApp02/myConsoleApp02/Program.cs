/*VARIAVEIS E COMANDOS ARITMETICOS E CONDICIONAIS*/

// int var1 = 10;
// int var2 = 20;
// int var3 = 30;

// Console.WriteLine(var1);
// Console.WriteLine(var2);
// Console.WriteLine(var3);

// Console.WriteLine(var1 < var2);
// Console.WriteLine(var2 == var3);

// var1++;
// var3--;

// Console.WriteLine(var1);
// Console.WriteLine(var3);

internal class Program
{
    private static void Main(string[] args)
    {
        int dia = 10;
        int mes = 20;
        int ano = 30;

        Console.WriteLine(dia);
        Console.WriteLine(mes);
        Console.WriteLine(ano);

        Console.WriteLine(dia != mes);
        Console.WriteLine(ano > mes);

        Console.WriteLine(dia == ano);

        int var = ano - mes;
        Console.WriteLine( var == dia);
    }
}