namespace Dip.Model
{
    class SQLProdutProcess : DBProduct
    {
        public string GetByProductId(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
