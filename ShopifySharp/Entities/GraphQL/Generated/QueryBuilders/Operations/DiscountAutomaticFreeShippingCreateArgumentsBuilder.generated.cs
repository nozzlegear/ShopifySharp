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