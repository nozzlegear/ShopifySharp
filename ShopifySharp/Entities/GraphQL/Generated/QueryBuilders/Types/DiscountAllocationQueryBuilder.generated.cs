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
    public sealed class DiscountAllocationQueryBuilder : FieldsQueryBuilderBase<DiscountAllocation, DiscountAllocationQueryBuilder>
    {
        protected override DiscountAllocationQueryBuilder Self => this;

        public DiscountAllocationQueryBuilder() : this("discountAllocation")
        {
        }

        public DiscountAllocationQueryBuilder(string name) : base(new Query<DiscountAllocation>(name))
        {
        }

        public DiscountAllocationQueryBuilder(IQuery<DiscountAllocation> query) : base(query)
        {
        }

        public DiscountAllocationQueryBuilder AllocatedAmount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("allocatedAmount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountAllocationQueryBuilder AllocatedAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("allocatedAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DiscountAllocationQueryBuilder DiscountApplication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("discountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }
    }
}