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
    public sealed class DiscountAutomaticFreeShippingUpdateArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticFreeShippingUpdatePayload, DiscountAutomaticFreeShippingUpdateArgumentsBuilder>
    {
        protected override DiscountAutomaticFreeShippingUpdateArgumentsBuilder Self => this;

        public DiscountAutomaticFreeShippingUpdateArgumentsBuilder(IQuery<DiscountAutomaticFreeShippingUpdatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticFreeShippingUpdateArgumentsBuilder FreeShippingAutomaticDiscount(DiscountAutomaticFreeShippingInput? freeShippingAutomaticDiscount)
        {
            base.InnerQuery.AddArgument("freeShippingAutomaticDiscount", freeShippingAutomaticDiscount);
            return this;
        }

        public DiscountAutomaticFreeShippingUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}