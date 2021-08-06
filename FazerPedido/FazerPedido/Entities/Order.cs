using FazerPedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FazerPedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Cliente client)
        {
            Moment = moment;
            Status = status;
            Cliente = client;
        }

        public void AddItem(OrdemItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrdemItem item in Items)
            {
                sum += item.Price;
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Cliente);
            sb.AppendLine("Order items:");
            foreach (OrdemItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        

    }
}
