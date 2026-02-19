namespace SistemInformaticaAtelierAuto.Web.Models

{
    public class Car
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string NrInmatriculare { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        public ICollection<Programare>? Programari { get; set; }
    }
}
