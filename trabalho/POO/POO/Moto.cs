using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Moto : Veiculo
    {
        public bool temPartidaEletrica {  get; set; }

        override
        public void ExibirDetalhes()
        {
            Console.WriteLine($"{this.marca} {this.modelo} {this.ano} {this.valor} {this.cor} {this.temPartidaEletrica}");
        }
    }
}
