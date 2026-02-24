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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class LineItemDiscountedTotalSetArgumentsBuilder : ArgumentsBuilderBase<MoneyBag?, LineItemDiscountedTotalSetArgumentsBuilder>
    {
        protected override LineItemDiscountedTotalSetArgumentsBuilder Self => this;

        public LineItemDiscountedTotalSetArgumentsBuilder(IQuery<MoneyBag?> query) : base(query)
        {
        }

        public LineItemDiscountedTotalSetArgumentsBuilder WithCodeDiscounts(bool? withCodeDiscounts)
        {
            base.InnerQuery.AddArgument("withCodeDiscounts", withCodeDiscounts);
            return this;
        }
    }
}