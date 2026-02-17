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
    public sealed class DiscountMinimumSubtotalQueryBuilder : FieldsQueryBuilderBase<DiscountMinimumSubtotal, DiscountMinimumSubtotalQueryBuilder>
    {
        protected override DiscountMinimumSubtotalQueryBuilder Self => this;

        public DiscountMinimumSubtotalQueryBuilder() : this("discountMinimumSubtotal")
        {
        }

        public DiscountMinimumSubtotalQueryBuilder(string name) : base(new Query<DiscountMinimumSubtotal>(name))
        {
        }

        public DiscountMinimumSubtotalQueryBuilder(IQuery<DiscountMinimumSubtotal> query) : base(query)
        {
        }

        public DiscountMinimumSubtotalQueryBuilder GreaterThanOrEqualToSubtotal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("greaterThanOrEqualToSubtotal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}