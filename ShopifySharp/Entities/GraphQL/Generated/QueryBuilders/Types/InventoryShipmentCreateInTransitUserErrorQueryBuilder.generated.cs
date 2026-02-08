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
    public sealed class InventoryShipmentCreateInTransitUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentCreateInTransitUserError, InventoryShipmentCreateInTransitUserErrorQueryBuilder>
    {
        protected override InventoryShipmentCreateInTransitUserErrorQueryBuilder Self => this;

        public InventoryShipmentCreateInTransitUserErrorQueryBuilder() : this("inventoryShipmentCreateInTransitUserError")
        {
        }

        public InventoryShipmentCreateInTransitUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentCreateInTransitUserError>(name))
        {
        }

        public InventoryShipmentCreateInTransitUserErrorQueryBuilder(IQuery<InventoryShipmentCreateInTransitUserError> query) : base(query)
        {
        }

        public InventoryShipmentCreateInTransitUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentCreateInTransitUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentCreateInTransitUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}