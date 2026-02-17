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
    public sealed class MetafieldDefinitionPinArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionPinPayload, MetafieldDefinitionPinArgumentsBuilder>
    {
        protected override MetafieldDefinitionPinArgumentsBuilder Self => this;

        public MetafieldDefinitionPinArgumentsBuilder(IQuery<MetafieldDefinitionPinPayload> query) : base(query)
        {
        }

        public MetafieldDefinitionPinArgumentsBuilder DefinitionId(string? definitionId)
        {
            base.InnerQuery.AddArgument("definitionId", definitionId);
            return this;
        }

        public MetafieldDefinitionPinArgumentsBuilder Identifier(MetafieldDefinitionIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}