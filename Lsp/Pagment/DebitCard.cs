using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Pagment
{
    class DebitCard: NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificando saldo da conta....");
            Console.WriteLine("Saldo disponível.");            
        }
    }
}
