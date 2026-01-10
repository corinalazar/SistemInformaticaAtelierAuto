namespace SistemInformaticaAtelierAuto.Web.Models
{
    public class Programare
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descriere { get; set; } = string.Empty;
        public decimal Cost { get; set; }

        public int CarId { get; set; }
        public Car? Car { get; set; }
    }
}
