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
    public sealed class DeliveryPromiseParticipantsArgumentsBuilder : ArgumentsBuilderBase<DeliveryPromiseParticipantConnection, DeliveryPromiseParticipantsArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantsArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantsArgumentsBuilder(IQuery<DeliveryPromiseParticipantConnection> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryPromiseParticipantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryPromiseParticipantsArgumentsBuilder BrandedPromiseHandle(string? brandedPromiseHandle)
        {
            base.InnerQuery.AddArgument("brandedPromiseHandle", brandedPromiseHandle);
            return this;
        }

        public DeliveryPromiseParticipantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryPromiseParticipantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryPromiseParticipantsArgumentsBuilder OwnerIds(ICollection<string>? ownerIds)
        {
            base.InnerQuery.AddArgument("ownerIds", ownerIds);
            return this;
        }

        public DeliveryPromiseParticipantsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}