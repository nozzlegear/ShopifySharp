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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MetafieldDefinitionArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinition, MetafieldDefinitionArgumentsBuilder>
    {
        protected override MetafieldDefinitionArgumentsBuilder Self => this;

        public MetafieldDefinitionArgumentsBuilder(IQuery<MetafieldDefinition> query) : base(query)
        {
        }

        public MetafieldDefinitionArgumentsBuilder Identifier(MetafieldDefinitionIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}