using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeandoBancoRelacional.Dados
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SOBRENOME { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Name}, {SOBRENOME}";
        }

    }
}
