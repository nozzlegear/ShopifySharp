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
    public sealed class OrderStagedChangeRemoveShippingLineQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeRemoveShippingLine, OrderStagedChangeRemoveShippingLineQueryBuilder>
    {
        protected override OrderStagedChangeRemoveShippingLineQueryBuilder Self => this;

        public OrderStagedChangeRemoveShippingLineQueryBuilder() : this("orderStagedChangeRemoveShippingLine")
        {
        }

        public OrderStagedChangeRemoveShippingLineQueryBuilder(string name) : base(new Query<OrderStagedChangeRemoveShippingLine>(name))
        {
        }

        public OrderStagedChangeRemoveShippingLineQueryBuilder(IQuery<OrderStagedChangeRemoveShippingLine> query) : base(query)
        {
        }

        public OrderStagedChangeRemoveShippingLineQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }
    }
}