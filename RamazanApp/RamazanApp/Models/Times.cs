using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamazanApp.Models
{
    public class Times
    {
        public int id { get; set; }
        public int cityId { get; set; }
        public int dateId { get; set; }
        public string imsak { get; set; }
        public string ogle { get; set; }
        public string ikindi { get; set; }
        public string aksam { get; set; }
        public string yatsi { get; set; }
        public Cities cities { get; set; }
        public Dates dates { get; set; }
    }
}
