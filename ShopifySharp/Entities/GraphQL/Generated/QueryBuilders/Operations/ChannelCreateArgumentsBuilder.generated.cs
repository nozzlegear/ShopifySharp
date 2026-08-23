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
    public sealed class ChannelCreateArgumentsBuilder : ArgumentsBuilderBase<ChannelCreatePayload, ChannelCreateArgumentsBuilder>
    {
        protected override ChannelCreateArgumentsBuilder Self => this;

        public ChannelCreateArgumentsBuilder(IQuery<ChannelCreatePayload> query) : base(query)
        {
        }

        public ChannelCreateArgumentsBuilder Input(ChannelCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}