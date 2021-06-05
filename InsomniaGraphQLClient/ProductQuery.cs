using GraphQL.Types;

namespace InsomniaGraphQLClient
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
            name: "products", resolve: context =>
            {
                return productRepository.GetProducts();
            });
        }
    }
}
