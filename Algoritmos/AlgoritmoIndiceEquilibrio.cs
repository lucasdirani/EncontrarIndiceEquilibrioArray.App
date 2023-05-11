namespace EncontrarIndiceEquilibrioArray.App.Algoritmos
{
    public static class AlgoritmoIndiceEquilibrio
    {
        public static int EncontrarIndiceDeEquilibrioEmComplexidadeQuadratica(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int somaDaEsquerda = 0;
                for (int j = 0; j < i; j++)
                {
                    somaDaEsquerda += arr[i];
                }
                int somaDaDireita = 0;
                for(int j = i + 1; j < n; j++)
                {
                    somaDaDireita += arr[i];
                }
                if (somaDaEsquerda == somaDaDireita)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int EncontrarIndiceDeEquilibrioEmComplexidadeLinear(int[] arr, int n)
        {
            int soma = 0;
            int somaDaEsquerda = 0;
            for (int i = 0; i < n; i++)
            {
                soma += arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                soma -= arr[i];
                if (soma == somaDaEsquerda)
                {
                    return i;
                }
                somaDaEsquerda += arr[i];
            }
            return -1;
        }
    }
}