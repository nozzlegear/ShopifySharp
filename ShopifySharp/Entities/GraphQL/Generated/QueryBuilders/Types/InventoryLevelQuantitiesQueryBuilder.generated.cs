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
    public sealed class InventoryLevelQuantitiesQueryBuilder : FieldsQueryBuilderBase<InventoryQuantity, InventoryLevelQuantitiesQueryBuilder>, IHasArguments<InventoryLevelQuantitiesArgumentsBuilder>
    {
        public InventoryLevelQuantitiesArgumentsBuilder Arguments { get; }
        protected override InventoryLevelQuantitiesQueryBuilder Self => this;

        public InventoryLevelQuantitiesQueryBuilder(string name) : base(new Query<InventoryQuantity>(name))
        {
            Arguments = new InventoryLevelQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryLevelQuantitiesQueryBuilder(IQuery<InventoryQuantity> query) : base(query)
        {
            Arguments = new InventoryLevelQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryLevelQuantitiesQueryBuilder SetArguments(Action<InventoryLevelQuantitiesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryLevelQuantitiesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryLevelQuantitiesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryLevelQuantitiesQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public InventoryLevelQuantitiesQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}