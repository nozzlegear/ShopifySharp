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
    public sealed class CustomerSetUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerSetUserError, CustomerSetUserErrorQueryBuilder>
    {
        protected override CustomerSetUserErrorQueryBuilder Self => this;

        public CustomerSetUserErrorQueryBuilder() : this("customerSetUserError")
        {
        }

        public CustomerSetUserErrorQueryBuilder(string name) : base(new Query<CustomerSetUserError>(name))
        {
        }

        public CustomerSetUserErrorQueryBuilder(IQuery<CustomerSetUserError> query) : base(query)
        {
        }

        public CustomerSetUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerSetUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerSetUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}