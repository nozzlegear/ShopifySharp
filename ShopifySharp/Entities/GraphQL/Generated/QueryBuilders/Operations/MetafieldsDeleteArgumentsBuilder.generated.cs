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
    public sealed class MetafieldsDeleteArgumentsBuilder : ArgumentsBuilderBase<MetafieldsDeletePayload, MetafieldsDeleteArgumentsBuilder>
    {
        protected override MetafieldsDeleteArgumentsBuilder Self => this;

        public MetafieldsDeleteArgumentsBuilder(IQuery<MetafieldsDeletePayload> query) : base(query)
        {
        }

        public MetafieldsDeleteArgumentsBuilder Metafields(ICollection<MetafieldIdentifierInput>? metafields)
        {
            base.InnerQuery.AddArgument("metafields", metafields);
            return this;
        }
    }
}