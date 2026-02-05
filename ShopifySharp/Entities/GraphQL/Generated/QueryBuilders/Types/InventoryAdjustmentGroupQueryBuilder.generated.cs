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
    public sealed class InventoryAdjustmentGroupQueryBuilder : FieldsQueryBuilderBase<InventoryAdjustmentGroup, InventoryAdjustmentGroupQueryBuilder>
    {
        protected override InventoryAdjustmentGroupQueryBuilder Self => this;

        public InventoryAdjustmentGroupQueryBuilder() : this("inventoryAdjustmentGroup")
        {
        }

        public InventoryAdjustmentGroupQueryBuilder(string name) : base(new Query<InventoryAdjustmentGroup>(name))
        {
        }

        public InventoryAdjustmentGroupQueryBuilder(IQuery<InventoryAdjustmentGroup> query) : base(query)
        {
        }

        public InventoryAdjustmentGroupQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public InventoryAdjustmentGroupQueryBuilder Changes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryChangeQueryBuilder> build)
        {
            var query = new Query<InventoryChange>("changes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryChangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryChange>(query);
            return this;
        }

        public InventoryAdjustmentGroupQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public InventoryAdjustmentGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryAdjustmentGroupQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }

        public InventoryAdjustmentGroupQueryBuilder ReferenceDocumentUri()
        {
            base.InnerQuery.AddField("referenceDocumentUri");
            return this;
        }

        public InventoryAdjustmentGroupQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }
    }
}