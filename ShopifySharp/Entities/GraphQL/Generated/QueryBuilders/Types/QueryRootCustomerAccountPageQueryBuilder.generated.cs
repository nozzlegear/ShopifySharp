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
    public sealed class QueryRootCustomerAccountPageQueryBuilder : FieldsQueryBuilderBase<ICustomerAccountPage, QueryRootCustomerAccountPageQueryBuilder>, IHasArguments<QueryRootCustomerAccountPageArgumentsBuilder>
    {
        public QueryRootCustomerAccountPageArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerAccountPageQueryBuilder Self => this;

        public QueryRootCustomerAccountPageQueryBuilder(string name) : base(new Query<ICustomerAccountPage>(name))
        {
            Arguments = new QueryRootCustomerAccountPageArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerAccountPageQueryBuilder(IQuery<ICustomerAccountPage> query) : base(query)
        {
            Arguments = new QueryRootCustomerAccountPageArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerAccountPageQueryBuilder SetArguments(Action<QueryRootCustomerAccountPageArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerAccountPageQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public QueryRootCustomerAccountPageQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootCustomerAccountPageQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCustomerAccountPageQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}