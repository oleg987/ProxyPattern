using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ClientProxy : IClient
    {
        public static List<Client> Clients { get; set; } = new List<Client>();

        public Client Client { get; set; }
        public string ClientPhone { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }

        public ClientProxy(string phone, string name = null, string address = null)
        {
            ClientPhone = phone;
            ClientName = name;
            ClientAddress = address;
            Client = new Client();
        }

        public Client GetClient()
        {    
            foreach (Client item in Clients)
            {
                if (item.Phone == ClientPhone)
                {
                    return item;
                }
            }

            Client.Name = ClientName;
            Client.Address = ClientAddress;
            Client.Phone = ClientPhone;

            return Client.GetClient();
        }
    }
}
