/*ESTRUTURAS DE REPETIÇÃO (FOR, WHILE, DOWHILE, FOREACH)*/

internal class Program{
    private static void Main(string[] args){
        int var1 = 10;
        int var2 = 20;
        int var3 = 30;

        for (int i = 1; i <= 5; i++){
            Console.WriteLine("Volta: "+ i);

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);

            Console.WriteLine(var1 < var2);
            Console.WriteLine(var2 == var3);

            var1++;
            var3--;

            Console.WriteLine(var1);
            Console.WriteLine(var3);

            var1 += 10;
            var2 += 10;
            var3 += 10;
        }
    }
}