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
    public sealed class InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentUpdateItemQuantitiesUserError, InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder>
    {
        protected override InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder Self => this;

        public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder() : this("inventoryShipmentUpdateItemQuantitiesUserError")
        {
        }

        public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentUpdateItemQuantitiesUserError>(name))
        {
        }

        public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder(IQuery<InventoryShipmentUpdateItemQuantitiesUserError> query) : base(query)
        {
        }

        public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}