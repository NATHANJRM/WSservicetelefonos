using busdatacel.claseexterna;
using busdatacel.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busdatacel
{
    public class daocelulares
    {
        public List<celularesext> obtener()
        {
            using (ge19EntitiesVIERNES data = new ge19EntitiesVIERNES())
            {
                List<celulares> list = data.celulares.Include("marcas").ToList();
                List<celularesext> listex = new List<celularesext>();
                foreach (celulares item in list)
                {
                    celularesext ex = new celularesext();
                    marcasext mx = new marcasext();
                    ex.id = item.id;
                    ex.nombre = item.nombre;
                    ex.capacidad = item.capacidad;
                    ex.memoria = item.memoria;
                    ex.precio = item.precio;
                    ex.idmarca = item.idmarca;

                    mx.id = item.idmarca.Value;
                    mx.marca = item.marcas.marca;

                    ex.marcasext = mx;

                    listex.Add(ex);
                }                
                return listex;
            }
        }

        public celularesext obtenerid(int id)
        {
            using (ge19EntitiesVIERNES data = new ge19EntitiesVIERNES())
            {
                celulares item = data.celulares.Include("marcas").Where(x => x.id == id).FirstOrDefault();
                celularesext itemext = new celularesext();

                celularesext ex = new celularesext();
                marcasext mx = new marcasext();
                
                ex.id = item.id;
                ex.nombre = item.nombre;
                ex.capacidad = item.capacidad;
                ex.memoria = item.memoria;
                ex.precio = item.precio;
                ex.idmarca = item.idmarca;

                mx.id = item.idmarca.Value;
                mx.marca = item.marcas.marca;

                ex.marcasext = mx;

                return ex;
            } 
        }

        public void agregar(celulares cel)
        {
            using (ge19EntitiesVIERNES data = new ge19EntitiesVIERNES())
            {
                data.celulares.Add(cel);
                data.SaveChanges();
            }
        }

        public void delete (int id)
        {
            using (ge19EntitiesVIERNES data = new ge19EntitiesVIERNES())
            {
                celulares tel = data.celulares.Include("marcas").Where(x => x.id == id).FirstOrDefault();
                celulares cel = data.celulares.Find(tel.id);

                data.celulares.Remove(cel);
                data.SaveChanges ();
                
            }            
        }

        public celularesext edit (celularesext cel)
        {
            using (ge19EntitiesVIERNES data = new ge19EntitiesVIERNES())
            {
                celulares tel = data.celulares.Find (cel.id);

                tel.nombre = cel.nombre;
                tel.capacidad = cel.capacidad;
                tel.memoria = cel.memoria;
                tel.precio = cel.precio;
                tel.idmarca = cel.idmarca;

                data.SaveChanges () ;
                return cel;
            }
        }
    }
}
