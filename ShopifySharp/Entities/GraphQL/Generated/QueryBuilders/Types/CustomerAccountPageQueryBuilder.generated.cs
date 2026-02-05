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
    public sealed class CustomerAccountPageQueryBuilder : FieldsQueryBuilderBase<ICustomerAccountPage, CustomerAccountPageQueryBuilder>
    {
        protected override CustomerAccountPageQueryBuilder Self => this;

        public CustomerAccountPageQueryBuilder() : this("customerAccountPage")
        {
        }

        public CustomerAccountPageQueryBuilder(string name) : base(new Query<ICustomerAccountPage>(name))
        {
        }

        public CustomerAccountPageQueryBuilder(IQuery<ICustomerAccountPage> query) : base(query)
        {
        }

        public CustomerAccountPageQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public CustomerAccountPageQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public CustomerAccountPageQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerAccountPageQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}