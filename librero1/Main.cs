namespace librero1
{
    public class Main
    {
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
        }
    }
}