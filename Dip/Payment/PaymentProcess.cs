using Dip.Factory;
using Dip.Model;
using System;

namespace Dip.Payment
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            DBProduct product = DBProductFactory.Create();
            string productData = product.GetByProductId(id);
            Console.WriteLine(productData);
        }
    }
}
