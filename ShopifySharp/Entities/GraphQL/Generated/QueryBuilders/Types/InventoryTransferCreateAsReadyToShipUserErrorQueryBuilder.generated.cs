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
    public sealed class InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder : FieldsQueryBuilderBase<InventoryTransferCreateAsReadyToShipUserError, InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder>
    {
        protected override InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder Self => this;

        public InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder() : this("inventoryTransferCreateAsReadyToShipUserError")
        {
        }

        public InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder(string name) : base(new Query<InventoryTransferCreateAsReadyToShipUserError>(name))
        {
        }

        public InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder(IQuery<InventoryTransferCreateAsReadyToShipUserError> query) : base(query)
        {
        }

        public InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}