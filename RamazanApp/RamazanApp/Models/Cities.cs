using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RamazanApp.Models
{
    public class Cities
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public override string ToString()
        {
            return CityName;
        }
    }

}

