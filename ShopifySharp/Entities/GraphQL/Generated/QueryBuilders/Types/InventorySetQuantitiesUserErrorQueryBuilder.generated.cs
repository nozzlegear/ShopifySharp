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
    public sealed class InventorySetQuantitiesUserErrorQueryBuilder : FieldsQueryBuilderBase<InventorySetQuantitiesUserError, InventorySetQuantitiesUserErrorQueryBuilder>
    {
        protected override InventorySetQuantitiesUserErrorQueryBuilder Self => this;

        public InventorySetQuantitiesUserErrorQueryBuilder() : this("inventorySetQuantitiesUserError")
        {
        }

        public InventorySetQuantitiesUserErrorQueryBuilder(string name) : base(new Query<InventorySetQuantitiesUserError>(name))
        {
        }

        public InventorySetQuantitiesUserErrorQueryBuilder(IQuery<InventorySetQuantitiesUserError> query) : base(query)
        {
        }

        public InventorySetQuantitiesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventorySetQuantitiesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventorySetQuantitiesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}