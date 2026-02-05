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
    public sealed class PublishableUnpublishToCurrentChannelArgumentsBuilder : ArgumentsBuilderBase<PublishableUnpublishToCurrentChannelPayload, PublishableUnpublishToCurrentChannelArgumentsBuilder>
    {
        protected override PublishableUnpublishToCurrentChannelArgumentsBuilder Self => this;

        public PublishableUnpublishToCurrentChannelArgumentsBuilder(IQuery<PublishableUnpublishToCurrentChannelPayload> query) : base(query)
        {
        }

        public PublishableUnpublishToCurrentChannelArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}