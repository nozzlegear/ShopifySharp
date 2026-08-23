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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder : ArgumentsBuilderBase<ChannelConnection?, DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder(IQuery<ChannelConnection?> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryPromiseParticipantOwnerUnpublishedChannelsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}