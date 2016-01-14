using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Equipos.Models
{
    public class Equipos
    {
        public long ID { get; set; }
        public string SERIE { get; set; }
        public string MODELO { get; set; }
        public TIPO_EQUIPO TIPO_EQUIPO_ID { get; set; }
        public MARCA_EQUIPO MARCA_EQUIPO_ID { get; set; }
        public string PROCESADOR { get; set; }
        public string MEMORIA { get; set; }
        public string DISCO_DURO { get; set; }
        public string MAC_ETH { get; set; }
        public string MAC_WIFI { get; set; }
        public TECLADO NO_SERIE_TECLADO { get; set; }
        public MOUSE NO_SERIE_MOUSE { get; set; }
        public MONITOR NO_SERIE_MONITOR { get; set; }
        public DOCK_STATION NO_SERIE_DOCK_STATION { get; set; }
        public CANDADO NO_SERIE_CANDADO { get; set; }
    }
}
