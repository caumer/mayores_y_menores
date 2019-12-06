using System;

namespace mayores_y_menores
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            uint cont = 0, numeroMenor = 0, numeroMayor = 0;

            while (cont < 10)
            {
                Console.Write("Ingrese número:");
                numero = float.Parse(Console.ReadLine());

                if (numero > 0)
                    numeroMayor++;
                if (numero < 0)
                    numeroMenor++;

                cont++;
            }

            Console.WriteLine("De 10 números son ...\nMenores a 0  = {0} y mayores a 0 = {1}", numeroMenor, numeroMayor);
            Console.ReadLine();
        }
    }
}
