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
    public sealed class QueryRootDeliveryPromiseParticipantsArgumentsBuilder : ArgumentsBuilderBase<DeliveryPromiseParticipantConnection?, QueryRootDeliveryPromiseParticipantsArgumentsBuilder>
    {
        protected override QueryRootDeliveryPromiseParticipantsArgumentsBuilder Self => this;

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder(IQuery<DeliveryPromiseParticipantConnection?> query) : base(query)
        {
        }

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder BrandedPromiseHandle(string? brandedPromiseHandle)
        {
            base.InnerQuery.AddArgument("brandedPromiseHandle", brandedPromiseHandle);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder OwnerIds(ICollection<string>? ownerIds)
        {
            base.InnerQuery.AddArgument("ownerIds", ownerIds);
            return this;
        }

        public QueryRootDeliveryPromiseParticipantsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}