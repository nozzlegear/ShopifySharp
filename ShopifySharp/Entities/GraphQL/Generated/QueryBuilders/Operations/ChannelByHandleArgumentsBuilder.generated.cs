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
    public sealed class ChannelByHandleArgumentsBuilder : ArgumentsBuilderBase<Channel, ChannelByHandleArgumentsBuilder>
    {
        protected override ChannelByHandleArgumentsBuilder Self => this;

        public ChannelByHandleArgumentsBuilder(IQuery<Channel> query) : base(query)
        {
        }

        public ChannelByHandleArgumentsBuilder Handle(string? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }
    }
}