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
    public sealed class InventoryShipmentDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentDeleteUserError, InventoryShipmentDeleteUserErrorQueryBuilder>
    {
        protected override InventoryShipmentDeleteUserErrorQueryBuilder Self => this;

        public InventoryShipmentDeleteUserErrorQueryBuilder() : this("inventoryShipmentDeleteUserError")
        {
        }

        public InventoryShipmentDeleteUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentDeleteUserError>(name))
        {
        }

        public InventoryShipmentDeleteUserErrorQueryBuilder(IQuery<InventoryShipmentDeleteUserError> query) : base(query)
        {
        }

        public InventoryShipmentDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}