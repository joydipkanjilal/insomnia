﻿namespace InsomniaGraphQLClient
{
    public class GraphQLQueryDTO
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public string Variables { get; set; }
    }
}
