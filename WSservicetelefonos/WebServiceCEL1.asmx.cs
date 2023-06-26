using busdatacel;
using busdatacel.claseexterna;
using busdatacel.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSservicetelefonos
{
    /// <summary>
    /// Descripción breve de WebServiceCEL1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCEL1 : System.Web.Services.WebService
    {
        daocelulares daotel = new daocelulares();
        daomarcas daomar = new daomarcas();

        [WebMethod]
        public List<celularesext> obtenercel() 
        {
            List<celularesext> list = daotel.obtener();
            return list;
        }

        [WebMethod]
        public celularesext obtenerid(int id)
        {
            celularesext cel = daotel.obtenerid(id);
            return cel;
            
        }

        [WebMethod]
        public void agregar(celularesext tel)
        {
            celulares cel = new celulares()
            {
                id = tel.id,
                nombre = tel.nombre,
                capacidad = tel.capacidad,
                memoria = tel.memoria,
                precio = tel.precio,
                idmarca = tel.idmarca
            };
            daotel.agregar(cel);
        }

        [WebMethod]
        public List<marcasext> obtenermar()
        {
            List<marcasext> list = daomar.obtener();
            return list;
        }

        [WebMethod]
        public void delete(int id)
        {
            daotel.delete(id);
        }

        [WebMethod]
        public void edit(celularesext tel)
        {            
            daotel.edit(tel);
        }
    }
}
