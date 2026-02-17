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
    public sealed class DiscountCodeAppCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeAppCreatePayload, DiscountCodeAppCreateArgumentsBuilder>
    {
        protected override DiscountCodeAppCreateArgumentsBuilder Self => this;

        public DiscountCodeAppCreateArgumentsBuilder(IQuery<DiscountCodeAppCreatePayload> query) : base(query)
        {
        }

        public DiscountCodeAppCreateArgumentsBuilder CodeAppDiscount(DiscountCodeAppInput? codeAppDiscount)
        {
            base.InnerQuery.AddArgument("codeAppDiscount", codeAppDiscount);
            return this;
        }
    }
}