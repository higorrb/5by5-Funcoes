//4- faça um programa que leia um numer inteiro e mostre todos os numeros primos até ele, inclusive ele mesmo

bool EPrimo(int num)
{
    if (num <= 1)
        return false;

    int contador = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
            contador++;
    }
    if (contador > 2)
        return false;
    else
        return true;

}

void CaminhoPrimo(int num)
{
    if (EPrimo(num))
        Console.WriteLine("O numero é primo");
    else
        Console.WriteLine("o numero NÃO é primo");

    int contador = 0;

    for (int i = 2; i <= num; i++)
    {
        contador = 0;
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0)
            {
                contador++;
            }
            if (contador > 2)
            {
                break;
            }
        }
        if (contador == 2)
        {
            if(i == num)
            {
                Console.Write(i + " <-- NUMERO DIGITADO");
                break;
            }
            Console.Write(i + " ");
        }
    }
}

Console.Write("Digite um numero para saber os PRIMOS ate ele: ");
CaminhoPrimo(int.Parse(Console.ReadLine()));