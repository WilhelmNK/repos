int[] numeros = new int[10];


for (int i = 0; i < 10; i++) // i<10 quer dizer q ele faz 10 numeros
{
    Console.Write($"Digite o {i + 1}º numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nResultados das somas:");

for (int i=0; i<5; i++) // aq o i e <5 n deveria ser 10? a respota é ; agr eles estao em pares assim sendo 5 e nao 10
{
    int soma = numeros[i] + numeros[9 - i];
    Console.WriteLine($"{numeros[i]} + {numeros[9 - i]} = {soma}");
}
Console.ReadLine();
