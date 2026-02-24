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
    public sealed class InventoryTransferLineItemsCountQueryBuilder : FieldsQueryBuilderBase<Count, InventoryTransferLineItemsCountQueryBuilder>, IHasArguments<InventoryTransferLineItemsCountArgumentsBuilder>
    {
        public InventoryTransferLineItemsCountArgumentsBuilder Arguments { get; }
        protected override InventoryTransferLineItemsCountQueryBuilder Self => this;

        public InventoryTransferLineItemsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new InventoryTransferLineItemsCountArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferLineItemsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new InventoryTransferLineItemsCountArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferLineItemsCountQueryBuilder SetArguments(Action<InventoryTransferLineItemsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryTransferLineItemsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public InventoryTransferLineItemsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}