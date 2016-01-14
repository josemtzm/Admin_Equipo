using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Equipos.Models
{
    class Asignaciones
    {
        public Usuarios USUARIO_ID { get; set; }
        public Equipos NO_SERIE { get; set; }
        public bool ASIGNADO { get; set; }
        public DateTime FECHA_ALTA { get; set; }
        public DateTime FECHA_BAJA { get; set; }
    }
}
