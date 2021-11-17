using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Pagment
{
    abstract class NubankCard : IPagmentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento Realizado");
        }

        public virtual void Validate()
        {
            //Validacao do cartao
        }
    }
}
