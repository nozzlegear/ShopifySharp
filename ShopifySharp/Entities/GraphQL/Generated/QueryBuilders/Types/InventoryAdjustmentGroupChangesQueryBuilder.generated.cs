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
    public sealed class InventoryAdjustmentGroupChangesQueryBuilder : FieldsQueryBuilderBase<InventoryChange, InventoryAdjustmentGroupChangesQueryBuilder>, IHasArguments<InventoryAdjustmentGroupChangesArgumentsBuilder>
    {
        public InventoryAdjustmentGroupChangesArgumentsBuilder Arguments { get; }
        protected override InventoryAdjustmentGroupChangesQueryBuilder Self => this;

        public InventoryAdjustmentGroupChangesQueryBuilder(string name) : base(new Query<InventoryChange>(name))
        {
            Arguments = new InventoryAdjustmentGroupChangesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryAdjustmentGroupChangesQueryBuilder(IQuery<InventoryChange> query) : base(query)
        {
            Arguments = new InventoryAdjustmentGroupChangesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryAdjustmentGroupChangesQueryBuilder SetArguments(Action<InventoryAdjustmentGroupChangesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryAdjustmentGroupChangesQueryBuilder Delta()
        {
            base.InnerQuery.AddField("delta");
            return this;
        }

        public InventoryAdjustmentGroupChangesQueryBuilder Item(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("item");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryAdjustmentGroupChangesQueryBuilder LedgerDocumentUri()
        {
            base.InnerQuery.AddField("ledgerDocumentUri");
            return this;
        }

        public InventoryAdjustmentGroupChangesQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public InventoryAdjustmentGroupChangesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryAdjustmentGroupChangesQueryBuilder QuantityAfterChange()
        {
            base.InnerQuery.AddField("quantityAfterChange");
            return this;
        }
    }
}