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
    public sealed class CompanyContactConnectionQueryBuilder : FieldsQueryBuilderBase<CompanyContactConnection, CompanyContactConnectionQueryBuilder>
    {
        protected override CompanyContactConnectionQueryBuilder Self => this;

        public CompanyContactConnectionQueryBuilder() : this("companyContactConnection")
        {
        }

        public CompanyContactConnectionQueryBuilder(string name) : base(new Query<CompanyContactConnection>(name))
        {
        }

        public CompanyContactConnectionQueryBuilder(IQuery<CompanyContactConnection> query) : base(query)
        {
        }

        public CompanyContactConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyContactEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactEdge>(query);
            return this;
        }

        public CompanyContactConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CompanyContactConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}