using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    internal class Item
    {
        private readonly int id;
        private string name;
        private string info;
        private float cost;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 200)
                    throw new ArgumentException("Длина поля превышает 200 символов.");
                name = value;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                if (value.Length > 1000)
                    throw new ArgumentException("Длина поля превышает 1000 символов.");
                info = value;
            }
        }

        public float Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value < 0 || value > 100000)
                    throw new ArgumentOutOfRangeException(nameof(cost));
    
                    cost = value;
            }
        }
        public Item() { }
    }
}
