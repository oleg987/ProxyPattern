using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Order
    {
        public List<Product> Products { get; set; }
        public Client Client { get; set; }

        public Order(List<Product> products, string phone, string name = null, string address = null)
        {
            Products = products;
            IClient clientProxy = new ClientProxy(phone, name, address);
            Client = clientProxy.GetClient();
        }
    }
}
