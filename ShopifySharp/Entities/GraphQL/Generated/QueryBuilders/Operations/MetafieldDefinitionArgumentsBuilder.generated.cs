#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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