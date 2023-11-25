class program
{
    static void Main()
    {
        // Mostra o resultado
        foreach (int numero in GerarFibonacci(15))
        {
            Console.WriteLine(numero);
        }
    }

    // A função já gera os 2 primeiros números da sequência para que seja possível dar inicio 
    // a sequencia, somando os dois anteriores para gerar o número 
    static int[] GerarFibonacci(int quantidade)
    {
        int[] numeros = new int[quantidade];

        // Dois números da sequência
        numeros[0] = 0;
        numeros[1] = 1;

        // Gerando os números
        for (int i = 2; i < quantidade; i++)
        {
            numeros[i] = numeros[i - 1] + numeros[i - 2];
        }

        return numeros;
    }
}
