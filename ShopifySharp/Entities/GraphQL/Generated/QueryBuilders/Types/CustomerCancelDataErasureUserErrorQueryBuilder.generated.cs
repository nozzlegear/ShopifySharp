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
    public sealed class CustomerCancelDataErasureUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerCancelDataErasureUserError, CustomerCancelDataErasureUserErrorQueryBuilder>
    {
        protected override CustomerCancelDataErasureUserErrorQueryBuilder Self => this;

        public CustomerCancelDataErasureUserErrorQueryBuilder() : this("customerCancelDataErasureUserError")
        {
        }

        public CustomerCancelDataErasureUserErrorQueryBuilder(string name) : base(new Query<CustomerCancelDataErasureUserError>(name))
        {
        }

        public CustomerCancelDataErasureUserErrorQueryBuilder(IQuery<CustomerCancelDataErasureUserError> query) : base(query)
        {
        }

        public CustomerCancelDataErasureUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerCancelDataErasureUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerCancelDataErasureUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}