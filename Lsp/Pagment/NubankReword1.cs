using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Pagment
{
    class NubankReword1 : IPagmentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada.");
        }

        public void Validate()
        {
            Console.WriteLine("Limite ok, Rewords ok!");
        }
    }
}

