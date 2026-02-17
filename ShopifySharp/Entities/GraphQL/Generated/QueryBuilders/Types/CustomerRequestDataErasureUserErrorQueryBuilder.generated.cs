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
    public sealed class CustomerRequestDataErasureUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerRequestDataErasureUserError, CustomerRequestDataErasureUserErrorQueryBuilder>
    {
        protected override CustomerRequestDataErasureUserErrorQueryBuilder Self => this;

        public CustomerRequestDataErasureUserErrorQueryBuilder() : this("customerRequestDataErasureUserError")
        {
        }

        public CustomerRequestDataErasureUserErrorQueryBuilder(string name) : base(new Query<CustomerRequestDataErasureUserError>(name))
        {
        }

        public CustomerRequestDataErasureUserErrorQueryBuilder(IQuery<CustomerRequestDataErasureUserError> query) : base(query)
        {
        }

        public CustomerRequestDataErasureUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerRequestDataErasureUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerRequestDataErasureUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}