using Dip.Model;
using System;

namespace Dip.Payment
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            SQLProdutProcess product = new SQLProdutProcess();
            string productData = product.GetByProductId(id);
            Console.WriteLine(productData);
        }
    }
}
