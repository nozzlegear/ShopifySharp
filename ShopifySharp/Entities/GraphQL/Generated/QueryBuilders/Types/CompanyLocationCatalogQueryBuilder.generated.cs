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
    public sealed class CompanyLocationCatalogQueryBuilder : FieldsQueryBuilderBase<CompanyLocationCatalog, CompanyLocationCatalogQueryBuilder>
    {
        protected override CompanyLocationCatalogQueryBuilder Self => this;

        public CompanyLocationCatalogQueryBuilder() : this("companyLocationCatalog")
        {
        }

        public CompanyLocationCatalogQueryBuilder(string name) : base(new Query<CompanyLocationCatalog>(name))
        {
        }

        public CompanyLocationCatalogQueryBuilder(IQuery<CompanyLocationCatalog> query) : base(query)
        {
        }

        public CompanyLocationCatalogQueryBuilder CompanyLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyLocationConnection>("companyLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationConnection>(query);
            return this;
        }

        public CompanyLocationCatalogQueryBuilder CompanyLocationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("companyLocationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CompanyLocationCatalogQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyLocationCatalogQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public CompanyLocationCatalogQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public CompanyLocationCatalogQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CompanyLocationCatalogQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CompanyLocationCatalogQueryBuilder Operations(Action<ResourceOperationInterfaceCasesBuilder> build)
        {
            var query = new Query<IResourceOperation>("operations");
            var unionBuilder = new ResourceOperationInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}