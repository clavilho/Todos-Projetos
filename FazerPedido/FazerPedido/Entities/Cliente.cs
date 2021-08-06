using System;
using System.Collections.Generic;
using System.Text;

namespace FazerPedido.Entities
{
    class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Cliente(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
