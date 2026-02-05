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
    public sealed class DraftOrderPlatformDiscountAllocationQueryBuilder : FieldsQueryBuilderBase<DraftOrderPlatformDiscountAllocation, DraftOrderPlatformDiscountAllocationQueryBuilder>
    {
        protected override DraftOrderPlatformDiscountAllocationQueryBuilder Self => this;

        public DraftOrderPlatformDiscountAllocationQueryBuilder() : this("draftOrderPlatformDiscountAllocation")
        {
        }

        public DraftOrderPlatformDiscountAllocationQueryBuilder(string name) : base(new Query<DraftOrderPlatformDiscountAllocation>(name))
        {
        }

        public DraftOrderPlatformDiscountAllocationQueryBuilder(IQuery<DraftOrderPlatformDiscountAllocation> query) : base(query)
        {
        }

        public DraftOrderPlatformDiscountAllocationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DraftOrderPlatformDiscountAllocationQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public DraftOrderPlatformDiscountAllocationQueryBuilder ReductionAmount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("reductionAmount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DraftOrderPlatformDiscountAllocationQueryBuilder ReductionAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("reductionAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderPlatformDiscountAllocationQueryBuilder Target(Action<DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder> build)
        {
            var query = new Query<DraftOrderPlatformDiscountAllocationTarget>("target");
            var unionBuilder = new DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}