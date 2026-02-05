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
    public sealed class OrderCustomerRemoveUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderCustomerRemoveUserError, OrderCustomerRemoveUserErrorQueryBuilder>
    {
        protected override OrderCustomerRemoveUserErrorQueryBuilder Self => this;

        public OrderCustomerRemoveUserErrorQueryBuilder() : this("orderCustomerRemoveUserError")
        {
        }

        public OrderCustomerRemoveUserErrorQueryBuilder(string name) : base(new Query<OrderCustomerRemoveUserError>(name))
        {
        }

        public OrderCustomerRemoveUserErrorQueryBuilder(IQuery<OrderCustomerRemoveUserError> query) : base(query)
        {
        }

        public OrderCustomerRemoveUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderCustomerRemoveUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderCustomerRemoveUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}