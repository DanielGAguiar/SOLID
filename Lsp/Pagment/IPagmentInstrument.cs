
namespace Lsp.Pagment
{
    interface IPagmentInstrument
    {
        void Validate();

        void CollectPayment();
    }
}
