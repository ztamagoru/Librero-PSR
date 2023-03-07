using System.Diagnostics;

namespace librero1

{
    public class Librero1
    {
        public static void Main()
        {
            // El main 

            var firstline = Console.ReadLine();
            int N = int.Parse(firstline);

            var secondline = Console.ReadLine();
            var unparsedbases = secondline.Split(' ');
            var bases = new List<int>();
            foreach (var unparsedNumber in unparsedbases)
            {
                bases.Add(int.Parse(unparsedNumber));
            }

            if (bases.Count != N)
                throw new Exception("Cantidad de bases escritas no coincide con el primer parámetro.");

            var thirdline = Console.ReadLine();
            var unparsedlibros = thirdline.Split(' ');
            var libros = new List<int>();
            foreach (var unparsedNumber in unparsedlibros)
            {
                libros.Add(int.Parse(unparsedNumber));
            }

            if (libros.Count != N)
                throw new Exception("Cantidad de libros escritos no coincide con el primer parámetro.");

            Console.WriteLine(Librero(bases, libros));
        }

        public static int Librero(List<int> bases, List<int> libros)
        {
            // En el caso de que se esté testeando directamente desde el TDD, las siguientes líneas
            // verifican que la cantidad de libros y la cantidad de bases sea la misma.

            if (bases.Count != libros.Count)
                throw new Exception("cantidad de bases diferente a la cantidad de libros");

            // A continuación, guarda como la altura promedio

            int expected = (bases.Sum() + libros.Sum()) / bases.Count;

            if (bases.Any(bases => bases < 1 || bases > 1000))
                throw new Exception("Error. Altura de base menor a 1 o mayor 1000 encontrada.");

            if (libros.Any(libros => libros < 1 || libros > 1000))
                throw new Exception("Error. Altura de libro menor a 1 o mayor 1000 encontrada.");

            bases.Sort();

            libros.Sort();
            libros.Reverse();

            for (int i = 0; i < bases.Count; i++)
            {
                int x = bases[i] + libros[i];
                bool found = false;

                if (x == expected)
                    found = true;

                if (!found) { return -1; }
            }

            return expected;

            /* 
            for(int i = 0; i < bases.Count; i++)
            {
                bool found = false;

                for (int j = 0; j < libros.Count; j++)
                {
                    int x = 0;

                    if (libros[j] != -1) { x = bases[i] + libros[j]; }        

                    if (x == expected)
                    {
                        libros[j] = -1;
                        found = true;
                        break;
                    }
                }

                if (!found) { return -1; }
            } 

            return expected;
             */
        }
    }
}