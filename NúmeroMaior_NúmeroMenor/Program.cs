namespace NúmeroMaior_NúmeroMenor
{
    internal class Program
    {

        /*  Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de 
        um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO). */

        static void Main(string[] args)
        {
            int op = 1;
            List<int> numeros = new List<int>();

            for ( int i = 0; op != 0 ; i++ ) 
            {

                Console.WriteLine("Digite um número para ser lido, caso deseje parar de inserir números, aperte 0.");
                op = Convert.ToInt32(Console.ReadLine());
                if (op != 0)
                {
                    numeros.Add(op);
                }
                
            }
            numeros.Sort();

            Console.Clear();
            Console.WriteLine($"O número maior é {numeros.Last<int>()} e o numero menor é {numeros.First<int>()}");
        }
    }
}