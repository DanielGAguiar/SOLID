using Srp.Utils;
using System;

namespace Srp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cliente = new Client();
            String Nome = cliente.Createclient("Daniel");
            Notify notificar = new Notify();
            notificar.Notifyclient(Nome);
            Console.ReadLine();

        }      

        
    }
}
