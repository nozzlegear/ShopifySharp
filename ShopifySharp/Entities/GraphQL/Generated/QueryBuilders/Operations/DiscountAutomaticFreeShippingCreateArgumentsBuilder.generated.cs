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
    public sealed class DiscountAutomaticFreeShippingCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticFreeShippingCreatePayload, DiscountAutomaticFreeShippingCreateArgumentsBuilder>
    {
        protected override DiscountAutomaticFreeShippingCreateArgumentsBuilder Self => this;

        public DiscountAutomaticFreeShippingCreateArgumentsBuilder(IQuery<DiscountAutomaticFreeShippingCreatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticFreeShippingCreateArgumentsBuilder FreeShippingAutomaticDiscount(DiscountAutomaticFreeShippingInput? freeShippingAutomaticDiscount)
        {
            base.InnerQuery.AddArgument("freeShippingAutomaticDiscount", freeShippingAutomaticDiscount);
            return this;
        }
    }
}