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
    public sealed class InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferMarkAsReadyToShipUserError, InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder>
    {
        protected override InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder Self => this;

        public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder() : this("inventoryTransferMarkAsReadyToShipUserError")
        {
        }

        public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferMarkAsReadyToShipUserError>(name))
        {
        }

        public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder(IQuery<InventoryTransferMarkAsReadyToShipUserError> query) : base(query)
        {
        }

        public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}