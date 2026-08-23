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
    public sealed class QueryRootCatalogQueryBuilder : FieldsQueryBuilderBase<ICatalog, QueryRootCatalogQueryBuilder>, IHasArguments<QueryRootCatalogArgumentsBuilder>
    {
        public QueryRootCatalogArgumentsBuilder Arguments { get; }
        protected override QueryRootCatalogQueryBuilder Self => this;

        public QueryRootCatalogQueryBuilder(string name) : base(new Query<ICatalog>(name))
        {
            Arguments = new QueryRootCatalogArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCatalogQueryBuilder(IQuery<ICatalog> query) : base(query)
        {
            Arguments = new QueryRootCatalogArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCatalogQueryBuilder SetArguments(Action<QueryRootCatalogArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCatalogQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCatalogQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public QueryRootCatalogQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public QueryRootCatalogQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootCatalogQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootCatalogQueryBuilder OnAppCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder> build)
        {
            var query = new Query<AppCatalog>("... on AppCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootCatalogQueryBuilder OnCompanyLocationCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder> build)
        {
            var query = new Query<CompanyLocationCatalog>("... on CompanyLocationCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootCatalogQueryBuilder OnMarketCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder> build)
        {
            var query = new Query<MarketCatalog>("... on MarketCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootCatalogQueryBuilder Catalog(Action<CatalogInterfaceCasesBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var unionBuilder = new CatalogInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}