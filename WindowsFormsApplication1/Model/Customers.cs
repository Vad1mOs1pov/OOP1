using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Customers
    {
        private int id;
        private string fullname;
        private string address;

        public string Name
        {
            get
            {
                return fullname;
            }
            set
            {
                if (value.Length > 200)
                    throw new ArgumentException("Длина поля превышает 200 символов.");
                fullname = value;
            }
        }

        public string Adress
        {
            get
            {
                return address;
            }
            set
            {
                if (value.Length > 500)
                    throw new ArgumentException("Длина поля превышает 500 символов.");
                address = value;
            }
        }
        public Customers() { }

    }
}
