using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_App.Models
{
    public class Articulos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Stock { get; set; }

        public string Categoria { get; set; }

    }
}
