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
    public sealed class OrderMarkAsPaidPayloadQueryBuilder : FieldsQueryBuilderBase<OrderMarkAsPaidPayload, OrderMarkAsPaidPayloadQueryBuilder>
    {
        protected override OrderMarkAsPaidPayloadQueryBuilder Self => this;

        public OrderMarkAsPaidPayloadQueryBuilder() : this("orderMarkAsPaidPayload")
        {
        }

        public OrderMarkAsPaidPayloadQueryBuilder(string name) : base(new Query<OrderMarkAsPaidPayload>(name))
        {
        }

        public OrderMarkAsPaidPayloadQueryBuilder(IQuery<OrderMarkAsPaidPayload> query) : base(query)
        {
        }

        public OrderMarkAsPaidPayloadQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderMarkAsPaidPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}