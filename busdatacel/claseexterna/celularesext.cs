using busdatacel.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busdatacel.claseexterna
{
    public class celularesext
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string capacidad { get; set; }
        public string memoria { get; set; }
        public decimal precio { get; set; }
        public Nullable<int> idmarca { get; set; }

        public marcasext marcasext { get; set; }
    }
}
