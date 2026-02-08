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
    public sealed class CustomerVisitProductInfoEdgeQueryBuilder : FieldsQueryBuilderBase<CustomerVisitProductInfoEdge, CustomerVisitProductInfoEdgeQueryBuilder>
    {
        protected override CustomerVisitProductInfoEdgeQueryBuilder Self => this;

        public CustomerVisitProductInfoEdgeQueryBuilder() : this("customerVisitProductInfoEdge")
        {
        }

        public CustomerVisitProductInfoEdgeQueryBuilder(string name) : base(new Query<CustomerVisitProductInfoEdge>(name))
        {
        }

        public CustomerVisitProductInfoEdgeQueryBuilder(IQuery<CustomerVisitProductInfoEdge> query) : base(query)
        {
        }

        public CustomerVisitProductInfoEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CustomerVisitProductInfoEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfo>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfo>(query);
            return this;
        }
    }
}