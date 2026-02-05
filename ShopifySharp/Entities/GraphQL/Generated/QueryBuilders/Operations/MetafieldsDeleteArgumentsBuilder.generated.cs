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