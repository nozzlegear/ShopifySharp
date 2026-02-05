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
    public sealed class CustomerVisitProductInfoConnectionQueryBuilder : FieldsQueryBuilderBase<CustomerVisitProductInfoConnection, CustomerVisitProductInfoConnectionQueryBuilder>
    {
        protected override CustomerVisitProductInfoConnectionQueryBuilder Self => this;

        public CustomerVisitProductInfoConnectionQueryBuilder() : this("customerVisitProductInfoConnection")
        {
        }

        public CustomerVisitProductInfoConnectionQueryBuilder(string name) : base(new Query<CustomerVisitProductInfoConnection>(name))
        {
        }

        public CustomerVisitProductInfoConnectionQueryBuilder(IQuery<CustomerVisitProductInfoConnection> query) : base(query)
        {
        }

        public CustomerVisitProductInfoConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfoEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfoEdge>(query);
            return this;
        }

        public CustomerVisitProductInfoConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoQueryBuilder> build)
        {
            var query = new Query<CustomerVisitProductInfo>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitProductInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisitProductInfo>(query);
            return this;
        }

        public CustomerVisitProductInfoConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}