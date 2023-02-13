using System;   // Importação de dependências

namespace Projeto02
{
    class Triangulo
    {

        // Atributos da classe

        public double A; // O "public" permite que o atributo/método seja acessado de outros arquivos
        public double B;
        public double C;

        public double Area()    // => Método que retorna um valor double
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

    }
}
