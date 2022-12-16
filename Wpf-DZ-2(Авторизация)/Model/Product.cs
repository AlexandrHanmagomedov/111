using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_DZ_2_Заполнение_макета_.Model {
    internal class Product {

        public int ID { get; set; }
        public string Name { get; set; }

        public string Client { get; set; }

        public List<Product> Products { get; set; }

        public decimal Price { get { return Products.Sum ( x => x.Price ); }
        }
    }
}
