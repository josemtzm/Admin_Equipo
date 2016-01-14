namespace Admin_Equipos.Models
{
    public class OFICINAS
    {
        public long ID { get; set; }
        public CAT_ESTADOS ESTADO_ID { get; set; }
        public string CIUDAD { get; set; }
        public string CALLE { get; set; }
        public string NUMERO { get; set; }
        public string COLONIA { get; set; }
        public string DELEGACION { get; set; }
    }
}