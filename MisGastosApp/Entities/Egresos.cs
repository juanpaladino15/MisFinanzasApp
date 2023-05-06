namespace MisGastosApp.Entities
{
    public class Egresos
    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public decimal Monto { get; set; }

        public string Tipo { get; set; }

        public string ModoDePago { get; set; }

        public DateTime Fecha { get; set; }

    }
}
