using System.Diagnostics;

namespace librero1

{
    public class Librero1
    {
        public static void Main()
        {
            // El usuario ingresa la cantidad de libros y bases con las que cuenta.

            var firstline = Console.ReadLine();
            int N = int.Parse(firstline);

            // El usuario ingresa las medidas de las bases.

            var secondline = Console.ReadLine();
            var unparsedbases = secondline.Split(' ');
            var bases = new List<int>();
            foreach (var unparsedNumber in unparsedbases)
            {
                bases.Add(int.Parse(unparsedNumber));
            }

            // Si la cantidad de bases no es la misma a la cantidad de medidas ingresadas, tira un
            // error.

            if (bases.Count != N)
                throw new Exception("Cantidad de bases escritas no coincide con el primer parámetro.");

            // El usuario ingresa las alturas de los libros.

            var thirdline = Console.ReadLine();
            var unparsedlibros = thirdline.Split(' ');
            var libros = new List<int>();
            foreach (var unparsedNumber in unparsedlibros)
            {
                libros.Add(int.Parse(unparsedNumber));
            }

            // Si la cantidad de medidas ingresadas no es la misma a la cantidad de medidas ingresadas,
            // tira un error.

            if (libros.Count != N)
                throw new Exception("Cantidad de libros escritos no coincide con el primer parámetro.");

            // Le envía los datos ingresados a la función Librero y luego muestra el resultado en pantalla

            Console.WriteLine(Librero(bases, libros));
        }

        public static int Librero(List<int> bases, List<int> libros)
        {
            // En el caso de que se esté testeando directamente desde el TDD, las siguientes líneas
            // verifican que la cantidad de libros y la cantidad de bases sea la misma.

            if (bases.Count != libros.Count)
                throw new Exception("cantidad de bases diferente a la cantidad de libros");

            // A continuación, guarda como lo que sería la altura promedio que debería dar la suma
            // entre todos los pares de libros y bases para que estos tengan todos la misma altura.
            // Esta se obtiene sumando la medida de todas las bases y los libros, dividido por toda
            // la cantidad de libros prosentes.

            int expected = (bases.Sum() + libros.Sum()) / bases.Count;

            // En el caso de que alguna de la medida de las bases o de los libros sea menor a 1 o
            // mayor a 1000, tira error indicando donde está el error.

            if (bases.Any(bases => bases < 1 || bases > 1000))
                throw new Exception("Error. Altura de base menor a 1 o mayor 1000 encontrada.");

            if (libros.Any(libros => libros < 1 || libros > 1000))
                throw new Exception("Error. Altura de libro menor a 1 o mayor 1000 encontrada.");

            // Ordena las bases en orden ascendente y los libros en orden descendiente.

            bases.Sort();

            libros.Sort();
            libros.Reverse();

            // Dentro del for a continuación, se verifica q la suma del la medida del libro y de la
            // base en la posición i de como resultado la altura promedio. Si todos los pares dan el
            // promedio, devuelve el promedio al que se tiene que llegar. De ser contrario, devuelve -1.

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
            // De igual manera, se puede llegar a la solución mediante el 

            for (int i = 0; i < bases.Count; i++)
            {
                bool found = false;

                for (int j = 0; j < libros.Count; j++)
                {
                    int x = bases[i] + libros[j];

                    if (x == expected)
                    {
                        libros[j] = -1000;
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