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
    public sealed class QueryRootProductByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Product?, QueryRootProductByIdentifierArgumentsBuilder>
    {
        protected override QueryRootProductByIdentifierArgumentsBuilder Self => this;

        public QueryRootProductByIdentifierArgumentsBuilder(IQuery<Product?> query) : base(query)
        {
        }

        public QueryRootProductByIdentifierArgumentsBuilder Identifier(ProductIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}