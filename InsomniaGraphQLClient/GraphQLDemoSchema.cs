using GraphQL;
using GraphQL.Types;

namespace InsomniaGraphQLClient
{
    public class GraphQLDemoSchema : Schema, ISchema
    {
        public GraphQLDemoSchema(GraphQL.IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ProductQuery>();
        }
    }
}
