class Program
{
    static void Main()
    {
        // Exemplo de Array de números inteiros ordenada
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };

        Console.WriteLine("Digite um número");
        int numero = Int32.Parse(Console.ReadLine());
        // Chamando a função para buscar um número no array
        int posicao = BuscarNumero(array, numero);

        // Imprimindo o resultado
        if (posicao != -1)
        {
            Console.WriteLine($"O número {numero} está na posição {posicao + 1} da lista.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não está presente na lista.");
        }
    }

    //A função consiste Em fazer uma busca minimizando o gasto de processamento,
    //por ser uma lista ordenada de inteiros é possível partir do meio para a esquerda
    //ou para a direita buscando o número, reduzindo o uso de processamento pela metade 
    static int BuscarNumero(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (array[meio] == numero)
            {
                return meio; // O número foi encontrado na posição 'meio'
            }
            else if (array[meio] < numero)
            {
                esquerda = meio + 1; // O número está à direita do 'meio'
            }
            else
            {
                direita = meio - 1; // O número está à esquerda do 'meio'
            }
        }

        return -1; // O número não está presente no array
    }
}

