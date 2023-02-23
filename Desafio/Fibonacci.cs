namespace Desafio
{
    public static class Fibonacci
    {
        public static int[] Sequencia(int numero)
        {
            int[] fibonacci = new int[numero];
            fibonacci[0] = 1;
            fibonacci[1] = 1;
            for (int i = 2; i < numero; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }
    }
}