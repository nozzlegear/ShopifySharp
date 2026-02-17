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
    public sealed class DiscountCodeBasicCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeBasicCreatePayload, DiscountCodeBasicCreateArgumentsBuilder>
    {
        protected override DiscountCodeBasicCreateArgumentsBuilder Self => this;

        public DiscountCodeBasicCreateArgumentsBuilder(IQuery<DiscountCodeBasicCreatePayload> query) : base(query)
        {
        }

        public DiscountCodeBasicCreateArgumentsBuilder BasicCodeDiscount(DiscountCodeBasicInput? basicCodeDiscount)
        {
            base.InnerQuery.AddArgument("basicCodeDiscount", basicCodeDiscount);
            return this;
        }
    }
}