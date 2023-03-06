namespace librero1

{
    public class Librero1
    {
        public static void Main()
        {
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
            if (bases.Count != libros.Count)
                throw new Exception("cantidad de bases diferente a la cantidad de libros");

            int expected = (bases.Sum() + libros.Sum()) / bases.Count;

            for(int i = 0; i < bases.Count; i++)
            {
                bool found = false;

                for (int j = 0; j < libros.Count; j++)
                {
                    int x = bases[i] + libros[j];

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

            /* 
             
             */
        }
    }
}