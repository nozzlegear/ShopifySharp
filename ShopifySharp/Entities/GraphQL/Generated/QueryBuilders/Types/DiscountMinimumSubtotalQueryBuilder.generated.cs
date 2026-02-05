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

        public DiscountMinimumSubtotalQueryBuilder GreaterThanOrEqualToSubtotal(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("greaterThanOrEqualToSubtotal");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}