using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Carro : Veiculo
    {
        override
        public void ExibirDetalhes()
        {
            Console.WriteLine($"{this.marca} {this.modelo} {this.ano} {this.valor} {this.cor}");
        }
    }
}
