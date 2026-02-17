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
    public sealed class OrderCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderCreateUserError, OrderCreateUserErrorQueryBuilder>
    {
        protected override OrderCreateUserErrorQueryBuilder Self => this;

        public OrderCreateUserErrorQueryBuilder() : this("orderCreateUserError")
        {
        }

        public OrderCreateUserErrorQueryBuilder(string name) : base(new Query<OrderCreateUserError>(name))
        {
        }

        public OrderCreateUserErrorQueryBuilder(IQuery<OrderCreateUserError> query) : base(query)
        {
        }

        public OrderCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}