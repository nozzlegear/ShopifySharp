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
    public sealed class QueryRootMetafieldDefinitionArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinition?, QueryRootMetafieldDefinitionArgumentsBuilder>
    {
        protected override QueryRootMetafieldDefinitionArgumentsBuilder Self => this;

        public QueryRootMetafieldDefinitionArgumentsBuilder(IQuery<MetafieldDefinition?> query) : base(query)
        {
        }

        public QueryRootMetafieldDefinitionArgumentsBuilder Identifier(MetafieldDefinitionIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}