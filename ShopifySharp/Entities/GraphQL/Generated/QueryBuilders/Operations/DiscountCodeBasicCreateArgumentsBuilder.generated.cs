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