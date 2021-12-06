
namespace Dip.Model
{
    class SQLProdutProcess
    {
        public string GetByProductId(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
