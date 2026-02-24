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
    public sealed class DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder : ArgumentsBuilderBase<MetafieldConnection?, DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder(IQuery<MetafieldConnection?> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder Keys(ICollection<string>? keys)
        {
            base.InnerQuery.AddArgument("keys", keys);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}