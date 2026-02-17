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
    public sealed class InventoryQuantityNameQueryBuilder : FieldsQueryBuilderBase<InventoryQuantityName, InventoryQuantityNameQueryBuilder>
    {
        protected override InventoryQuantityNameQueryBuilder Self => this;

        public InventoryQuantityNameQueryBuilder() : this("inventoryQuantityName")
        {
        }

        public InventoryQuantityNameQueryBuilder(string name) : base(new Query<InventoryQuantityName>(name))
        {
        }

        public InventoryQuantityNameQueryBuilder(IQuery<InventoryQuantityName> query) : base(query)
        {
        }

        public InventoryQuantityNameQueryBuilder BelongsTo()
        {
            base.InnerQuery.AddField("belongsTo");
            return this;
        }

        public InventoryQuantityNameQueryBuilder Comprises()
        {
            base.InnerQuery.AddField("comprises");
            return this;
        }

        public InventoryQuantityNameQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public InventoryQuantityNameQueryBuilder IsInUse()
        {
            base.InnerQuery.AddField("isInUse");
            return this;
        }

        public InventoryQuantityNameQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}