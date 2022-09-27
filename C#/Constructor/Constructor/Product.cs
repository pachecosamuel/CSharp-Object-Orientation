using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructor {
    internal class Product {

        private string _name;
        public double Price { get; private set; }
        public double Quantidade { get; private set; }

        public Product() {
        }

        public Product(string name, double price, int amount) {
            _name = name;
            Price = price;
            Quantidade = amount;
        }

        public string Nome {
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Price * Quantidade;
        }

        public void AdicionarProdutos(int amount) {
            Quantidade += amount;         
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
