using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }

        public Address(string name, string surname, string street, string city, string province, string zip) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Zip = zip;
        }

        //public override string ToString()
        //{
        //    return $"Indirizzo di {this.Name} {this.Surname}: {this.Street} {this.City} {this.Province} {this.Zip}";
        //}

    }
}
