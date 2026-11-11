void Hello(string nome)
{
    Console.WriteLine("Hello, " + nome + "!");
}

Console.Write("digite seu nome: ");
Hello(Console.ReadLine());

//EXERCICIO PRIMOS COM FUNCAO
bool EPrimo(int num)
{
    if (num <= 1) 
        return false;

    int contador = 0;
    for (int i = 1; i <= num; i++)
    {
        if(num % i == 0) 
            contador++;
    }
    if (contador > 2)
        return false;
    else 
        return true;

}

Console.Write("Informe o numero desejado: ");

if (EPrimo(int.Parse(Console.ReadLine())))
    Console.Write("O numero é primo");
else
    Console.Write("o numero NÃO é primo");
