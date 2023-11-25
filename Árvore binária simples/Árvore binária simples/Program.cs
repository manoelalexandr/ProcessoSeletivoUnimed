using Árvore_binária_simples;

class Program
{
    static void Main()
    {
        //Cria uma instancia da arvore binária
        ArvoreBinaria arvore = new ArvoreBinaria();

        //Array com os 5 elementos
        int[] valores = { 4, 2, 1, 3, 5 };

        foreach (int valor in valores)
        {
            arvore.Inserir(valor);
        }

        Console.WriteLine("Valores da árvore em ordem:");
        arvore.PercorrerArvore(arvore.Raiz);
    }
}
