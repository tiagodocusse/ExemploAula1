namespace ExemploAula1
{
    /// <summary>
    /// Classe responsável pela inicialização do sistema
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Ponto de entrada do sistema
        /// </summary>
        static void Main()
        {
            Console.Write("Informe o primeiro número: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Informe o segundo número: ");
            int b = int.Parse(Console.ReadLine()!);

            Calculadora calc = new();
            int c = calc.Soma(a, b);

            Console.WriteLine($"A soma dos números é: {c}");
        }
    }

    /// <summary>
    /// Classe que realiza operações matemáticas básicas
    /// </summary>
    public class Calculadora
    {
        /// <summary>
        /// Operação de adição entre dois números inteiros
        /// </summary>
        /// <param name="a">Primeiro valor da adição</param>
        /// <param name="b">Segundo valor da adição</param>
        /// <returns>Resultado da soma entre os dois números informados</returns>
        public int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
