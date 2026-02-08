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
    public sealed class InventoryShipmentCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentCreateUserError, InventoryShipmentCreateUserErrorQueryBuilder>
    {
        protected override InventoryShipmentCreateUserErrorQueryBuilder Self => this;

        public InventoryShipmentCreateUserErrorQueryBuilder() : this("inventoryShipmentCreateUserError")
        {
        }

        public InventoryShipmentCreateUserErrorQueryBuilder(string name) : base(new Query<InventoryShipmentCreateUserError>(name))
        {
        }

        public InventoryShipmentCreateUserErrorQueryBuilder(IQuery<InventoryShipmentCreateUserError> query) : base(query)
        {
        }

        public InventoryShipmentCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryShipmentCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryShipmentCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}