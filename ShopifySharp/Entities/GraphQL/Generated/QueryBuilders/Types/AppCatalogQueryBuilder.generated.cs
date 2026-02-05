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
    public sealed class AppCatalogQueryBuilder : FieldsQueryBuilderBase<AppCatalog, AppCatalogQueryBuilder>
    {
        protected override AppCatalogQueryBuilder Self => this;

        public AppCatalogQueryBuilder() : this("appCatalog")
        {
        }

        public AppCatalogQueryBuilder(string name) : base(new Query<AppCatalog>(name))
        {
        }

        public AppCatalogQueryBuilder(IQuery<AppCatalog> query) : base(query)
        {
        }

        public AppCatalogQueryBuilder Apps(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppConnectionQueryBuilder> build)
        {
            var query = new Query<AppConnection>("apps");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppConnection>(query);
            return this;
        }

        public AppCatalogQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppCatalogQueryBuilder Operations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceOperationQueryBuilder> build)
        {
            var query = new Query<IResourceOperation>("operations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IResourceOperation>(query);
            return this;
        }

        public AppCatalogQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public AppCatalogQueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public AppCatalogQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public AppCatalogQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}