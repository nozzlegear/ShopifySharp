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
    public sealed class DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder : ArgumentsBuilderBase<ResourcePublicationConnection?, DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder(IQuery<ResourcePublicationConnection?> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder OnlyPublished(bool? onlyPublished)
        {
            base.InnerQuery.AddArgument("onlyPublished", onlyPublished);
            return this;
        }

        public DeliveryPromiseParticipantOwnerResourcePublicationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}