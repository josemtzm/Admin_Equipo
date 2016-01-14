namespace Admin_Equipos.Models
{
    public class CECO : CAT_BASE
    {
        public string NOMBRE { get; set; }
        public CAT_PERS PERS_ID { get; set; }
        public CAT_DIV DIV_ID { get; set; }
        public CAT_SUBDIV SUBDIV_ID { get; set; }
        public CAT_DIRECCION DIRECCION_ID { get; set; }
        public CAT_UNIDAD_ORG UNIDAD_ORG_ID { get; set; }
        public CAT_POSICION POSICION_ID { get; set; }
    }
}