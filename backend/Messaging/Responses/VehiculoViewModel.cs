namespace Messaging.Responses
{
    public class VehiculoViewModel
    {
        public int? Identificador { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ruedas { get; set; }
        public int NumeroChasis { get; set; }
        public int KilometrosRecorridos { get; set; }
        public int? KilometrosProximoMantenimiento { get; set; }
    }
}