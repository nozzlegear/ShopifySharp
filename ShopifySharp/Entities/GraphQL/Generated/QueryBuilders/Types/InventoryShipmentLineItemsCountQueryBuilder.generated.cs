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
    public sealed class InventoryShipmentLineItemsCountQueryBuilder : FieldsQueryBuilderBase<Count, InventoryShipmentLineItemsCountQueryBuilder>, IHasArguments<InventoryShipmentLineItemsCountArgumentsBuilder>
    {
        public InventoryShipmentLineItemsCountArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentLineItemsCountQueryBuilder Self => this;

        public InventoryShipmentLineItemsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new InventoryShipmentLineItemsCountArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentLineItemsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new InventoryShipmentLineItemsCountArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentLineItemsCountQueryBuilder SetArguments(Action<InventoryShipmentLineItemsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryShipmentLineItemsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public InventoryShipmentLineItemsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}