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