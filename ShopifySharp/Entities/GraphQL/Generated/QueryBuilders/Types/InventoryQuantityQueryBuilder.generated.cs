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
    public sealed class InventoryQuantityQueryBuilder : FieldsQueryBuilderBase<InventoryQuantity, InventoryQuantityQueryBuilder>, IHasArguments<InventoryQuantityArgumentsBuilder>
    {
        public InventoryQuantityArgumentsBuilder Arguments { get; }
        protected override InventoryQuantityQueryBuilder Self => this;

        public InventoryQuantityQueryBuilder() : this("inventoryQuantity")
        {
        }

        public InventoryQuantityQueryBuilder(string name) : base(new Query<InventoryQuantity>(name))
        {
            Arguments = new InventoryQuantityArgumentsBuilder(base.InnerQuery);
        }

        public InventoryQuantityQueryBuilder(IQuery<InventoryQuantity> query) : base(query)
        {
            Arguments = new InventoryQuantityArgumentsBuilder(base.InnerQuery);
        }

        public InventoryQuantityQueryBuilder SetArguments(Action<InventoryQuantityArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryQuantityQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryQuantityQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryQuantityQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public InventoryQuantityQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}