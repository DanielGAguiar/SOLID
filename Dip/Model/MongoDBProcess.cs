namespace Dip.Model
{
    class MongoDBProcess : DBProduct
    {
        public string GetByProductId(string id)
        {
            return $"MongoDB: Exibindo dados do produto {id}.";
        }

    }
}
