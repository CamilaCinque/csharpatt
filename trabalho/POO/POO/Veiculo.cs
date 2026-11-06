using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public abstract class Veiculo // superclasse
    {
        public string cor { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public string marca { get; set; }
        public double valor { get; set; }

        public abstract void ExibirDetalhes();
        

    }
}
