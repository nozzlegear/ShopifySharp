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
    public sealed class MetafieldDefinitionDeleteArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionDeletePayload, MetafieldDefinitionDeleteArgumentsBuilder>
    {
        protected override MetafieldDefinitionDeleteArgumentsBuilder Self => this;

        public MetafieldDefinitionDeleteArgumentsBuilder(IQuery<MetafieldDefinitionDeletePayload> query) : base(query)
        {
        }

        public MetafieldDefinitionDeleteArgumentsBuilder DeleteAllAssociatedMetafields(bool? deleteAllAssociatedMetafields)
        {
            base.InnerQuery.AddArgument("deleteAllAssociatedMetafields", deleteAllAssociatedMetafields);
            return this;
        }

        public MetafieldDefinitionDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public MetafieldDefinitionDeleteArgumentsBuilder Identifier(MetafieldDefinitionIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}