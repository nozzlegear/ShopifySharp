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
    public sealed class DiscountPurchaseAmountQueryBuilder : FieldsQueryBuilderBase<DiscountPurchaseAmount, DiscountPurchaseAmountQueryBuilder>
    {
        protected override DiscountPurchaseAmountQueryBuilder Self => this;

        public DiscountPurchaseAmountQueryBuilder() : this("discountPurchaseAmount")
        {
        }

        public DiscountPurchaseAmountQueryBuilder(string name) : base(new Query<DiscountPurchaseAmount>(name))
        {
        }

        public DiscountPurchaseAmountQueryBuilder(IQuery<DiscountPurchaseAmount> query) : base(query)
        {
        }

        public DiscountPurchaseAmountQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }
    }
}