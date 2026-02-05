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
    public sealed class DiscountCodeBasicUpdateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeBasicUpdatePayload, DiscountCodeBasicUpdateArgumentsBuilder>
    {
        protected override DiscountCodeBasicUpdateArgumentsBuilder Self => this;

        public DiscountCodeBasicUpdateArgumentsBuilder(IQuery<DiscountCodeBasicUpdatePayload> query) : base(query)
        {
        }

        public DiscountCodeBasicUpdateArgumentsBuilder BasicCodeDiscount(DiscountCodeBasicInput? basicCodeDiscount)
        {
            base.InnerQuery.AddArgument("basicCodeDiscount", basicCodeDiscount);
            return this;
        }

        public DiscountCodeBasicUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}