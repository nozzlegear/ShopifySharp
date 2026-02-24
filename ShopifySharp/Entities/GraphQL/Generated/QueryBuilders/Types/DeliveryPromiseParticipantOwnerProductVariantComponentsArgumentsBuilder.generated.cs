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
    public sealed class DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantComponentConnection?, DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder>
    {
        protected override DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder Self => this;

        public DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder(IQuery<ProductVariantComponentConnection?> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryPromiseParticipantOwnerProductVariantComponentsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}