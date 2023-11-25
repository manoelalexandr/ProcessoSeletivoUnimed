class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva uma palavra");
        // Exemplo de palavra para verificar se é um palíndromo
        string palavra = Console.ReadLine();

        // Chamando a função para verificar se a palavra é um palíndromo e imprimindo o resultado
        if (VerificarPalindromo(palavra))
        {
            Console.WriteLine($"'{palavra}' é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"'{palavra}' não é um palíndromo.");
        }
    }

    // Nessa função a string palavra é fragmenta como um array, onde cara letra dela é uma posição do array
    // e é feito uma verificação da primeira letra com a ultima, da segunda com a penúltima e assim sucessivamente 
    // e caso em algum momento essa verificação se tornar falsa a palavra não é um Palindromo
    static bool VerificarPalindromo(string palavra)
    {
        int tamanho = palavra.Length;
        for (int i = 0; i < tamanho / 2; i++)
        {
            if (palavra[i] != palavra[tamanho - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
