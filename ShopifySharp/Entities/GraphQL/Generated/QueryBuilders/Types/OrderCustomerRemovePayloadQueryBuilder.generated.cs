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
    public sealed class OrderCustomerRemovePayloadQueryBuilder : FieldsQueryBuilderBase<OrderCustomerRemovePayload, OrderCustomerRemovePayloadQueryBuilder>
    {
        protected override OrderCustomerRemovePayloadQueryBuilder Self => this;

        public OrderCustomerRemovePayloadQueryBuilder() : this("orderCustomerRemovePayload")
        {
        }

        public OrderCustomerRemovePayloadQueryBuilder(string name) : base(new Query<OrderCustomerRemovePayload>(name))
        {
        }

        public OrderCustomerRemovePayloadQueryBuilder(IQuery<OrderCustomerRemovePayload> query) : base(query)
        {
        }

        public OrderCustomerRemovePayloadQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCustomerRemovePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCustomerRemoveUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCustomerRemoveUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCustomerRemoveUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCustomerRemoveUserError>(query);
            return this;
        }
    }
}