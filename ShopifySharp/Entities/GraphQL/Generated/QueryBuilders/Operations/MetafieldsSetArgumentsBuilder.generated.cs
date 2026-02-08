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
    public sealed class MetafieldsSetArgumentsBuilder : ArgumentsBuilderBase<MetafieldsSetPayload, MetafieldsSetArgumentsBuilder>
    {
        protected override MetafieldsSetArgumentsBuilder Self => this;

        public MetafieldsSetArgumentsBuilder(IQuery<MetafieldsSetPayload> query) : base(query)
        {
        }

        public MetafieldsSetArgumentsBuilder Metafields(ICollection<MetafieldsSetInput>? metafields)
        {
            base.InnerQuery.AddArgument("metafields", metafields);
            return this;
        }
    }
}