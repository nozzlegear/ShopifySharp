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
    public sealed class OrderDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderDeleteUserError, OrderDeleteUserErrorQueryBuilder>
    {
        protected override OrderDeleteUserErrorQueryBuilder Self => this;

        public OrderDeleteUserErrorQueryBuilder() : this("orderDeleteUserError")
        {
        }

        public OrderDeleteUserErrorQueryBuilder(string name) : base(new Query<OrderDeleteUserError>(name))
        {
        }

        public OrderDeleteUserErrorQueryBuilder(IQuery<OrderDeleteUserError> query) : base(query)
        {
        }

        public OrderDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}