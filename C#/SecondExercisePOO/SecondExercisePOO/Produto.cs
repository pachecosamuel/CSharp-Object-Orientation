using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SecondExercisePOO {
    internal class Produto {

        public string Name;
        public double Price;
        public int Amount;

        public double ValorEmEstoque() {
            return Price * Amount;
        }

        public void AddProdutos(int qtd) {
            Amount += qtd;
        }

        public void RemoveProdutos(int qtd) {
            Amount -= qtd;
        }

        override public string ToString() {
            return
                "\nName: " + Name
                + " - Price: " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " - Amount " + Amount
                + " - Value in stock: " + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
