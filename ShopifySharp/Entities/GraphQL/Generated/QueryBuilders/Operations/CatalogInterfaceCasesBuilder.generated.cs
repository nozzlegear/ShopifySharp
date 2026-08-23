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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CatalogInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICatalog, CatalogInterfaceCasesBuilder>
    {
        protected override CatalogInterfaceCasesBuilder Self => this;

        public CatalogInterfaceCasesBuilder(string fieldName = "catalog") : this(new Query<ICatalog>(fieldName))
        {
        }

        public CatalogInterfaceCasesBuilder(IQuery<ICatalog> query) : base(query)
        {
        }

        public CatalogInterfaceCasesBuilder OnAppCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder> build)
        {
            var query = new Query<AppCatalog>("... on AppCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CatalogInterfaceCasesBuilder OnCompanyLocationCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder> build)
        {
            var query = new Query<CompanyLocationCatalog>("... on CompanyLocationCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CatalogInterfaceCasesBuilder OnMarketCatalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder> build)
        {
            var query = new Query<MarketCatalog>("... on MarketCatalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}