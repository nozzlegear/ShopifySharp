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
    public sealed class InventorySetOnHandQuantitiesUserErrorQueryBuilder : FieldsQueryBuilderBase<InventorySetOnHandQuantitiesUserError, InventorySetOnHandQuantitiesUserErrorQueryBuilder>
    {
        protected override InventorySetOnHandQuantitiesUserErrorQueryBuilder Self => this;

        public InventorySetOnHandQuantitiesUserErrorQueryBuilder() : this("inventorySetOnHandQuantitiesUserError")
        {
        }

        public InventorySetOnHandQuantitiesUserErrorQueryBuilder(string name) : base(new Query<InventorySetOnHandQuantitiesUserError>(name))
        {
        }

        public InventorySetOnHandQuantitiesUserErrorQueryBuilder(IQuery<InventorySetOnHandQuantitiesUserError> query) : base(query)
        {
        }

        public InventorySetOnHandQuantitiesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventorySetOnHandQuantitiesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventorySetOnHandQuantitiesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}