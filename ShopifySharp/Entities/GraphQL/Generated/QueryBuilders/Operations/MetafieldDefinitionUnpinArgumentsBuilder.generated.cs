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