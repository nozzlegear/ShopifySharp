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
    public sealed class InventoryMoveQuantitiesUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryMoveQuantitiesUserError, InventoryMoveQuantitiesUserErrorQueryBuilder>
    {
        protected override InventoryMoveQuantitiesUserErrorQueryBuilder Self => this;

        public InventoryMoveQuantitiesUserErrorQueryBuilder() : this("inventoryMoveQuantitiesUserError")
        {
        }

        public InventoryMoveQuantitiesUserErrorQueryBuilder(string name) : base(new Query<InventoryMoveQuantitiesUserError>(name))
        {
        }

        public InventoryMoveQuantitiesUserErrorQueryBuilder(IQuery<InventoryMoveQuantitiesUserError> query) : base(query)
        {
        }

        public InventoryMoveQuantitiesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryMoveQuantitiesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryMoveQuantitiesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}