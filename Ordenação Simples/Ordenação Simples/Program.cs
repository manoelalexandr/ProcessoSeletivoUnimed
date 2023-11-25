class Program
{
     static void Main()
    {
        // Array de números inteiros desordenados
        int[] numeros = { 7, 3, 8, 2, 5, 1, 6, 1, 2 };

        // Chamando a função para ordenar
        OrdenarLista(numeros);

        // Imprimindo a lista ordenada
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
    //Bubble Sort
    //Utilizando o algoritmo de ordenação Bubble Sort, onde ele trabalha parecido com uma matriz
    //sendo as linhas cada número que vai ser verificado até chegar na posição onde o proximo número não é menor que ele
    static void OrdenarLista(int[] lista)
    {
        for (int i = 0; i < lista.Length - 1; i++)
        {
        for (int j = 0; j < lista.Length - i - 1; j++)
        {
            if (lista[j] > lista[j + 1])
            {
                // Troca a posição dos elementos
                int temp = lista[j];
                lista[j] = lista[j + 1];
                lista[j + 1] = temp;
            }
        }
        }
    }
}