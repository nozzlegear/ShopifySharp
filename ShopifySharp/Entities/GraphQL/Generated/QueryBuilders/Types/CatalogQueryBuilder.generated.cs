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
    public sealed class CatalogQueryBuilder : FieldsQueryBuilderBase<ICatalog, CatalogQueryBuilder>, IHasArguments<CatalogArgumentsBuilder>
    {
        public CatalogArgumentsBuilder Arguments { get; }
        protected override CatalogQueryBuilder Self => this;

        public CatalogQueryBuilder() : this("catalog")
        {
        }

        public CatalogQueryBuilder(string name) : base(new Query<ICatalog>(name))
        {
            Arguments = new CatalogArgumentsBuilder(base.InnerQuery);
        }

        public CatalogQueryBuilder(IQuery<ICatalog> query) : base(query)
        {
            Arguments = new CatalogArgumentsBuilder(base.InnerQuery);
        }

        public CatalogQueryBuilder SetArguments(Action<CatalogArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CatalogQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CatalogQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public CatalogQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public CatalogQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CatalogQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CatalogQueryBuilder OnAppCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder> build)
        {
            var query = new Query<AppCatalog>("... on AppCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CatalogQueryBuilder OnCompanyLocationCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder> build)
        {
            var query = new Query<CompanyLocationCatalog>("... on CompanyLocationCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CatalogQueryBuilder OnMarketCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder> build)
        {
            var query = new Query<MarketCatalog>("... on MarketCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CatalogQueryBuilder Catalog(Action<CatalogInterfaceCasesBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var unionBuilder = new CatalogInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}