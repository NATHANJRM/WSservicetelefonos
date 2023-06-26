using busdatacel.claseexterna;
using busdatacel.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busdatacel
{
    public class daomarcas
    {
        public List<marcasext> obtener()
        {
            using (ge19EntitiesVIERNES data = new ge19EntitiesVIERNES())
            {
                List<marcas> list = data.marcas.ToList();
                List<marcasext> listex = new List<marcasext>();
                foreach (marcas item in list)
                {
                    marcasext mx = new marcasext();
                    mx.id = item.id;
                    mx.marca = item.marca;

                    listex.Add(mx);
                }
                return listex;
            }
        }

        //public void agregar(celulares cel)
        //{
        //    using (ge19EntitiesVIERNES data = new ge19EntitiesVIERNES())
        //    {
        //        data.celulares.Add(cel);
        //        data.SaveChanges();
        //    }
        //}
    }
}
