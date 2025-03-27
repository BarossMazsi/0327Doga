using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eutazas
{
    public class utasadat
    {

        public int megallo { get; set; }
        public string datum { get; set; }
        public int azon { get; set; }
        public string tipus { get; set; }
        public int ervenyesseg { get; set; }

        public utasadat(string sor)
        {
            string[] sz = sor.Split(' ');
            megallo= Convert.ToInt32(sz[0]);
            datum= sz[1];
            azon= Convert.ToInt32(sz[2]);
            tipus = sz[3];
            ervenyesseg= Convert.ToInt32(sz[4]);


        }
}
}
