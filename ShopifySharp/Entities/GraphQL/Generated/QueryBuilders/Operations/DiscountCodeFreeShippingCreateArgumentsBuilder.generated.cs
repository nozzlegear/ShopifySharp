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
    public sealed class DiscountCodeFreeShippingCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeFreeShippingCreatePayload, DiscountCodeFreeShippingCreateArgumentsBuilder>
    {
        protected override DiscountCodeFreeShippingCreateArgumentsBuilder Self => this;

        public DiscountCodeFreeShippingCreateArgumentsBuilder(IQuery<DiscountCodeFreeShippingCreatePayload> query) : base(query)
        {
        }

        public DiscountCodeFreeShippingCreateArgumentsBuilder FreeShippingCodeDiscount(DiscountCodeFreeShippingInput? freeShippingCodeDiscount)
        {
            base.InnerQuery.AddArgument("freeShippingCodeDiscount", freeShippingCodeDiscount);
            return this;
        }
    }
}