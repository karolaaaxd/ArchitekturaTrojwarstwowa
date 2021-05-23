using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CoreWebApplicationPage.Models
{
    public class Recenzja
    {
        public int Id { get; set; }

        public string RecenzjaUzytkownika { get; set; }
        public string Nick { get; set; }

        public double Ocena { get; set; }

        public Recenzja()
        {

        }
    }
}
