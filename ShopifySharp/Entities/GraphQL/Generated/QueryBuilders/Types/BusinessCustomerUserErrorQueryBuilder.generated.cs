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
    public sealed class BusinessCustomerUserErrorQueryBuilder : FieldsQueryBuilderBase<BusinessCustomerUserError, BusinessCustomerUserErrorQueryBuilder>
    {
        protected override BusinessCustomerUserErrorQueryBuilder Self => this;

        public BusinessCustomerUserErrorQueryBuilder() : this("businessCustomerUserError")
        {
        }

        public BusinessCustomerUserErrorQueryBuilder(string name) : base(new Query<BusinessCustomerUserError>(name))
        {
        }

        public BusinessCustomerUserErrorQueryBuilder(IQuery<BusinessCustomerUserError> query) : base(query)
        {
        }

        public BusinessCustomerUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BusinessCustomerUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BusinessCustomerUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}