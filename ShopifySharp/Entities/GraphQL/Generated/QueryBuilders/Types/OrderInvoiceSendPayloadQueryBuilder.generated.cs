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
    public sealed class OrderInvoiceSendPayloadQueryBuilder : FieldsQueryBuilderBase<OrderInvoiceSendPayload, OrderInvoiceSendPayloadQueryBuilder>
    {
        protected override OrderInvoiceSendPayloadQueryBuilder Self => this;

        public OrderInvoiceSendPayloadQueryBuilder() : this("orderInvoiceSendPayload")
        {
        }

        public OrderInvoiceSendPayloadQueryBuilder(string name) : base(new Query<OrderInvoiceSendPayload>(name))
        {
        }

        public OrderInvoiceSendPayloadQueryBuilder(IQuery<OrderInvoiceSendPayload> query) : base(query)
        {
        }

        public OrderInvoiceSendPayloadQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderInvoiceSendPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderInvoiceSendUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderInvoiceSendUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderInvoiceSendUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderInvoiceSendUserError>(query);
            return this;
        }
    }
}