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
    public sealed class InventoryScheduledChangeQueryBuilder : FieldsQueryBuilderBase<InventoryScheduledChange, InventoryScheduledChangeQueryBuilder>
    {
        protected override InventoryScheduledChangeQueryBuilder Self => this;

        public InventoryScheduledChangeQueryBuilder() : this("inventoryScheduledChange")
        {
        }

        public InventoryScheduledChangeQueryBuilder(string name) : base(new Query<InventoryScheduledChange>(name))
        {
        }

        public InventoryScheduledChangeQueryBuilder(IQuery<InventoryScheduledChange> query) : base(query)
        {
        }

        public InventoryScheduledChangeQueryBuilder ExpectedAt()
        {
            base.InnerQuery.AddField("expectedAt");
            return this;
        }

        public InventoryScheduledChangeQueryBuilder FromName()
        {
            base.InnerQuery.AddField("fromName");
            return this;
        }

        public InventoryScheduledChangeQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryScheduledChangeQueryBuilder LedgerDocumentUri()
        {
            base.InnerQuery.AddField("ledgerDocumentUri");
            return this;
        }

        public InventoryScheduledChangeQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public InventoryScheduledChangeQueryBuilder ToName()
        {
            base.InnerQuery.AddField("toName");
            return this;
        }
    }
}