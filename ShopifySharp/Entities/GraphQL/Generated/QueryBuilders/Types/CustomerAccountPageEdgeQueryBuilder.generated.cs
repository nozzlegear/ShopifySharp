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
    public sealed class CustomerAccountPageEdgeQueryBuilder : FieldsQueryBuilderBase<CustomerAccountPageEdge, CustomerAccountPageEdgeQueryBuilder>
    {
        protected override CustomerAccountPageEdgeQueryBuilder Self => this;

        public CustomerAccountPageEdgeQueryBuilder() : this("customerAccountPageEdge")
        {
        }

        public CustomerAccountPageEdgeQueryBuilder(string name) : base(new Query<CustomerAccountPageEdge>(name))
        {
        }

        public CustomerAccountPageEdgeQueryBuilder(IQuery<CustomerAccountPageEdge> query) : base(query)
        {
        }

        public CustomerAccountPageEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CustomerAccountPageEdgeQueryBuilder Node(Action<CustomerAccountPageInterfaceCasesBuilder> build)
        {
            var query = new Query<ICustomerAccountPage>("node");
            var unionBuilder = new CustomerAccountPageInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}