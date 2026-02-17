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
    public sealed class InventoryChangeQueryBuilder : FieldsQueryBuilderBase<InventoryChange, InventoryChangeQueryBuilder>
    {
        protected override InventoryChangeQueryBuilder Self => this;

        public InventoryChangeQueryBuilder() : this("inventoryChange")
        {
        }

        public InventoryChangeQueryBuilder(string name) : base(new Query<InventoryChange>(name))
        {
        }

        public InventoryChangeQueryBuilder(IQuery<InventoryChange> query) : base(query)
        {
        }

        public InventoryChangeQueryBuilder Delta()
        {
            base.InnerQuery.AddField("delta");
            return this;
        }

        public InventoryChangeQueryBuilder Item(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("item");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryChangeQueryBuilder LedgerDocumentUri()
        {
            base.InnerQuery.AddField("ledgerDocumentUri");
            return this;
        }

        public InventoryChangeQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public InventoryChangeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryChangeQueryBuilder QuantityAfterChange()
        {
            base.InnerQuery.AddField("quantityAfterChange");
            return this;
        }
    }
}