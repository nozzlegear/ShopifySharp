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
    public sealed class DiscountCodeBxgyCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeBxgyCreatePayload, DiscountCodeBxgyCreateArgumentsBuilder>
    {
        protected override DiscountCodeBxgyCreateArgumentsBuilder Self => this;

        public DiscountCodeBxgyCreateArgumentsBuilder(IQuery<DiscountCodeBxgyCreatePayload> query) : base(query)
        {
        }

        public DiscountCodeBxgyCreateArgumentsBuilder BxgyCodeDiscount(DiscountCodeBxgyInput? bxgyCodeDiscount)
        {
            base.InnerQuery.AddArgument("bxgyCodeDiscount", bxgyCodeDiscount);
            return this;
        }
    }
}