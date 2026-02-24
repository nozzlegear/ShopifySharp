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
    public sealed class CompanyLocationCatalogsQueryBuilder : FieldsQueryBuilderBase<CatalogConnection, CompanyLocationCatalogsQueryBuilder>, IHasArguments<CompanyLocationCatalogsArgumentsBuilder>
    {
        public CompanyLocationCatalogsArgumentsBuilder Arguments { get; }
        protected override CompanyLocationCatalogsQueryBuilder Self => this;

        public CompanyLocationCatalogsQueryBuilder(string name) : base(new Query<CatalogConnection>(name))
        {
            Arguments = new CompanyLocationCatalogsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCatalogsQueryBuilder(IQuery<CatalogConnection> query) : base(query)
        {
            Arguments = new CompanyLocationCatalogsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCatalogsQueryBuilder SetArguments(Action<CompanyLocationCatalogsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CompanyLocationCatalogsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogEdgeQueryBuilder> build)
        {
            var query = new Query<CatalogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogEdge>(query);
            return this;
        }

        public CompanyLocationCatalogsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CompanyLocationCatalogsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}