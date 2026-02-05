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
    public sealed class InventoryShipmentReceiveUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentReceiveUserError, InventoryShipmentReceiveUserErrorQueryBuilder>
    {
        protected override InventoryShipmentReceiveUserErrorQueryBuilder Self => this;

        public InventoryShipmentReceiveUserErrorQueryBuilder() : this("inventoryShipmentReceiveUserError")
        {
        }

        public InventoryShipmentReceiveUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentReceiveUserError>(name))
        {
        }

        public InventoryShipmentReceiveUserErrorQueryBuilder(IQuery<InventoryShipmentReceiveUserError> query) : base(query)
        {
        }

        public InventoryShipmentReceiveUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentReceiveUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentReceiveUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}