#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootCustomerByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Customer?, QueryRootCustomerByIdentifierArgumentsBuilder>
    {
        protected override QueryRootCustomerByIdentifierArgumentsBuilder Self => this;

        public QueryRootCustomerByIdentifierArgumentsBuilder(IQuery<Customer?> query) : base(query)
        {
        }

        public QueryRootCustomerByIdentifierArgumentsBuilder Identifier(CustomerIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}