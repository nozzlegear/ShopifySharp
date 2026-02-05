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