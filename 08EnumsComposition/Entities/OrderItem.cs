using System.Globalization;

namespace EnumsComposition.Entities
{
    class OrderItem
    {
        #region  Atributos/Properties

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        #endregion

        #region  Construtores

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        #endregion

        #region  Métodos

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

        #endregion
    }
}