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
    public sealed class DeliveryPromiseParticipantConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryPromiseParticipantConnection, DeliveryPromiseParticipantConnectionArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantConnectionArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantConnectionArgumentsBuilder(IQuery<DeliveryPromiseParticipantConnection> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryPromiseParticipantConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryPromiseParticipantConnectionArgumentsBuilder BrandedPromiseHandle(string? brandedPromiseHandle)
        {
            base.InnerQuery.AddArgument("brandedPromiseHandle", brandedPromiseHandle);
            return this;
        }

        public DeliveryPromiseParticipantConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryPromiseParticipantConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryPromiseParticipantConnectionArgumentsBuilder OwnerIds(ICollection<string>? ownerIds)
        {
            base.InnerQuery.AddArgument("ownerIds", ownerIds);
            return this;
        }

        public DeliveryPromiseParticipantConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}