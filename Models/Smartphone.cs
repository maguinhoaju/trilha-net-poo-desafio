namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"{Modelo} ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo} recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}