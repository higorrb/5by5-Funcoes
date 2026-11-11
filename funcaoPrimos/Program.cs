//4- faça um programa que leia um numer inteiro e mostre todos os numeros primos até ele, inclusive ele mesmo


void CaminhoPrimo(int num)
{
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
            Console.WriteLine(i);
        }
    }
}

Console.Write("Digite um numero para saber os PRIMOS ate ele: ");
CaminhoPrimo(int.Parse(Console.ReadLine()));