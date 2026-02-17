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
    public sealed class InventoryShipmentMarkInTransitUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentMarkInTransitUserError, InventoryShipmentMarkInTransitUserErrorQueryBuilder>
    {
        protected override InventoryShipmentMarkInTransitUserErrorQueryBuilder Self => this;

        public InventoryShipmentMarkInTransitUserErrorQueryBuilder() : this("inventoryShipmentMarkInTransitUserError")
        {
        }

        public InventoryShipmentMarkInTransitUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentMarkInTransitUserError>(name))
        {
        }

        public InventoryShipmentMarkInTransitUserErrorQueryBuilder(IQuery<InventoryShipmentMarkInTransitUserError> query) : base(query)
        {
        }

        public InventoryShipmentMarkInTransitUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentMarkInTransitUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentMarkInTransitUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}