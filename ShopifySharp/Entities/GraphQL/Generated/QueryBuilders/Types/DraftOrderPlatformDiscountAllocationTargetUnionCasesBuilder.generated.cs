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
    public sealed class DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder : UnionCasesBuilderBase<DraftOrderPlatformDiscountAllocationTarget, DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder>
    {
        protected override DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder Self => this;

        public DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder(string fieldName = "draftOrderPlatformDiscountAllocationTarget") : this(new Query<DraftOrderPlatformDiscountAllocationTarget>(fieldName))
        {
        }

        public DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder(IQuery<DraftOrderPlatformDiscountAllocationTarget> query) : base(query)
        {
        }

        public DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder OnCalculatedDraftOrderLineItem(Action<CalculatedDraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedDraftOrderLineItem>("... on CalculatedDraftOrderLineItem");
            var queryBuilder = new CalculatedDraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder OnDraftOrderLineItem(Action<DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("... on DraftOrderLineItem");
            var queryBuilder = new DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DraftOrderPlatformDiscountAllocationTargetUnionCasesBuilder OnShippingLine(Action<ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("... on ShippingLine");
            var queryBuilder = new ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}