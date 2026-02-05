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
    public sealed class OrderCancelUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderCancelUserError, OrderCancelUserErrorQueryBuilder>
    {
        protected override OrderCancelUserErrorQueryBuilder Self => this;

        public OrderCancelUserErrorQueryBuilder() : this("orderCancelUserError")
        {
        }

        public OrderCancelUserErrorQueryBuilder(string name) : base(new Query<OrderCancelUserError>(name))
        {
        }

        public OrderCancelUserErrorQueryBuilder(IQuery<OrderCancelUserError> query) : base(query)
        {
        }

        public OrderCancelUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderCancelUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderCancelUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}