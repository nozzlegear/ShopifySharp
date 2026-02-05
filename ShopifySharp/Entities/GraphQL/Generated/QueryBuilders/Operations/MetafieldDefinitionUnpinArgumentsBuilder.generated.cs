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
    public sealed class MetafieldDefinitionUnpinArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionUnpinPayload, MetafieldDefinitionUnpinArgumentsBuilder>
    {
        protected override MetafieldDefinitionUnpinArgumentsBuilder Self => this;

        public MetafieldDefinitionUnpinArgumentsBuilder(IQuery<MetafieldDefinitionUnpinPayload> query) : base(query)
        {
        }

        public MetafieldDefinitionUnpinArgumentsBuilder DefinitionId(string? definitionId)
        {
            base.InnerQuery.AddArgument("definitionId", definitionId);
            return this;
        }

        public MetafieldDefinitionUnpinArgumentsBuilder Identifier(MetafieldDefinitionIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}