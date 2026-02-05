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
    public sealed class CalculatedDiscountAllocationQueryBuilder : FieldsQueryBuilderBase<CalculatedDiscountAllocation, CalculatedDiscountAllocationQueryBuilder>
    {
        protected override CalculatedDiscountAllocationQueryBuilder Self => this;

        public CalculatedDiscountAllocationQueryBuilder() : this("calculatedDiscountAllocation")
        {
        }

        public CalculatedDiscountAllocationQueryBuilder(string name) : base(new Query<CalculatedDiscountAllocation>(name))
        {
        }

        public CalculatedDiscountAllocationQueryBuilder(IQuery<CalculatedDiscountAllocation> query) : base(query)
        {
        }

        public CalculatedDiscountAllocationQueryBuilder AllocatedAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("allocatedAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDiscountAllocationQueryBuilder DiscountApplication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ICalculatedDiscountApplication>("discountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICalculatedDiscountApplication>(query);
            return this;
        }
    }
}