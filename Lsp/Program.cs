using Lsp.Pagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            NubankReword1 card = new NubankReword1();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
