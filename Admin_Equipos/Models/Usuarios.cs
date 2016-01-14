using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Equipos.Models
{
    public class Usuarios
    {
        public long ID { get; set; }
        public string USER_ID { get; set; }
        public string NOMBRE { get; set; }
        public string PATERNO { get; set; }
        public string MATERNO { get; set; }
        public string TELEFONO { get; set; }
        public int EXT { get; set; }
        public string CORREO_E { get; set; }
        public string USUARIO_RED { get; set; }
        public AREAS AREA_ID { get; set; }
        public OFICINAS OFICINA_ID { get; set; }
        public bool ACTIVO { get; set; }
        public DateTime FECHA_ALTA { get; set; }
        public DateTime FECHA_BAJA { get; set; }
        public CECO CECO_ID { get; set; }
        public string OBSERVACIONES { get; set; }
    }
}
