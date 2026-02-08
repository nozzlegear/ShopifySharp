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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CustomerAccountPageOperationQueryBuilder : FieldsQueryBuilderBase<ICustomerAccountPage, CustomerAccountPageOperationQueryBuilder>, IGraphOperationQueryBuilder<ICustomerAccountPage>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomerAccountPageArgumentsBuilder Arguments { get; }
        protected override CustomerAccountPageOperationQueryBuilder Self => this;

        public CustomerAccountPageOperationQueryBuilder() : this("customerAccountPage")
        {
        }

        public CustomerAccountPageOperationQueryBuilder(string name) : base(new Query<ICustomerAccountPage>(name))
        {
            Arguments = new CustomerAccountPageArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAccountPageOperationQueryBuilder(IQuery<ICustomerAccountPage> query) : base(query)
        {
            Arguments = new CustomerAccountPageArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAccountPageOperationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public CustomerAccountPageOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public CustomerAccountPageOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerAccountPageOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}