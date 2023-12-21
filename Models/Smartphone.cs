using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string sistemaOperacional)
        {
            Numero = numero;
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
        }

        // Métodos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
