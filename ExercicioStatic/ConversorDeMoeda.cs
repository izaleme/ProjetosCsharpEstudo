namespace ExercicioStatic
{
    class ConversorDeMoeda
    {
        static public double iof = 6.0;

        public static double ConvertDolarToReal(double quantidade, double cotacao)
        {
            double total = quantidade * cotacao;
            return total + total * iof / 100;
        }
    }
}
