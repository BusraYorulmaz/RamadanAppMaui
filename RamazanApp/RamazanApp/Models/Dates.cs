using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamazanApp.Models
{
    public class Dates
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public override string ToString()
        {
            return Date;
        }
    }
}
