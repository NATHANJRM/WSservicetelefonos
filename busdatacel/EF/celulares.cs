//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace busdatacel.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class celulares
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string capacidad { get; set; }
        public string memoria { get; set; }
        public decimal precio { get; set; }
        public Nullable<int> idmarca { get; set; }
    
        public virtual marcas marcas { get; set; }
    }
}
