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
    public sealed class DraftOrderPlatformDiscountAllocationTargetQueryBuilder : FieldsQueryBuilderBase<DraftOrderPlatformDiscountAllocationTarget, DraftOrderPlatformDiscountAllocationTargetQueryBuilder>
    {
        protected override DraftOrderPlatformDiscountAllocationTargetQueryBuilder Self => this;

        public DraftOrderPlatformDiscountAllocationTargetQueryBuilder() : this("draftOrderPlatformDiscountAllocationTarget")
        {
        }

        public DraftOrderPlatformDiscountAllocationTargetQueryBuilder(string name) : base(new Query<DraftOrderPlatformDiscountAllocationTarget>(name))
        {
        }

        public DraftOrderPlatformDiscountAllocationTargetQueryBuilder(IQuery<DraftOrderPlatformDiscountAllocationTarget> query) : base(query)
        {
        }

        public DraftOrderPlatformDiscountAllocationTargetQueryBuilder DraftOrderPlatformDiscountAllocationTarget(Action<DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder> build)
        {
            var query = new Query<DraftOrderPlatformDiscountAllocationTarget>("draftOrderPlatformDiscountAllocationTarget");
            var unionBuilder = new DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}