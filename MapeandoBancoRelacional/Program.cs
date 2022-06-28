using MapeandoBancoRelacional.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeandoBancoRelacional
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new MapeamentoContext()){

                
                Console.WriteLine(contexto.Cliente.ToString());
            }
            Console.ReadLine();
        }
    }
}
