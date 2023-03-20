using System;

namespace EnumsComposition.Entities
{
    class Product
    {
        #region  Atributos/Properties

        public string Name { get; set; }
        public double Price { get; set; }

        #endregion

        #region  Construtores

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        #endregion
    }
}