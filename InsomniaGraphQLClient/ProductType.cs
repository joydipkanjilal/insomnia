using GraphQL.Types;

namespace InsomniaGraphQLClient
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Name = "Product";
            Field(_ => _.Id).Description("Product ID.");
            Field(_ => _.Code).Description("Product Code");
            Field(_ => _.Name).Description("Product Name");
        }
    }
}
