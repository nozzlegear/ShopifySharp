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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
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