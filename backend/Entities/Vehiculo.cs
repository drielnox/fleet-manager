namespace Entities
{
    public class Vehiculo
    {
        private const int KMS_POR_MANTENIMIENTO = 100000;

        public int Identificador { get; }

        private int _ruedas;
        private string _marca;
        private string _modelo;

        public int Ruedas
        {
            get => _ruedas;
            set
            {
                if (value < 1)
                {
                    throw new Exception("El vehiculo debe tener dos o mas ruedas.");
                }

                _ruedas = value;
            }
        }

        public string Marca
        {
            get => _marca;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("La marca no puede ser nula o vacia.");
                }

                _marca = value;
            }
        }

        public string Modelo
        {
            get => _modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El modelo no peude ser nulo o vacio.");
                }

                _modelo = value;
            }
        }

        public int NumeroChasis { get; set; }

        public int KilometrosRecorridos { get; private set; }

        public int KilometrosProximoMantenimiento
        {
            get
            {
                decimal factor = KilometrosRecorridos / KMS_POR_MANTENIMIENTO;

                return ((int)Math.Round(factor, 0, MidpointRounding.ToZero) + 1) * KMS_POR_MANTENIMIENTO;
            }
        }

        public Vehiculo(string marca, string modelo, int ruedas)
        {
            Marca = marca;
            Modelo = modelo;
            Ruedas = ruedas;
        }

        public void SumarKilometraje(int kms)
        {
            if (kms <= 0)
            {
                throw new Exception("El kilometraje a sumar debe ser mayor a 0.");
            }

            KilometrosRecorridos += kms;
        }
    }
}